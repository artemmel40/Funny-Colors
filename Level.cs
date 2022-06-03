using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Zoo
{
	public class Position
	{
		public int row = 0;
		public int column = 0;
		public Position(int row, int column)
		{
			this.row = row;
			this.column = column;
		}
	}
	public enum GameObjectType
	{
		UserObject,
		DownObject,
		RightObject,
		NotUserObject
	}

	public enum Direction
	{
		UP,
		DOWN,
		RIGHT,
		LEFT
	}
	public class GameObject
	{
		public Position startPosition; // top left corner
		public Position endPosition; // bottom right corner
		public GameObjectType type;
		public Direction[] moveDirections;
		public Color Color;

		public GameObject(Position start, Position end, GameObjectType type, Direction[] moveDirections, Color color)
		{
			startPosition = start;
			endPosition = end;
			this.type = type;
			this.moveDirections = moveDirections;
			Color = color;
		}
	}

	public partial class Level : Form
	{
		public GameObject SelectObject = null;
		int SizeField = 7;
		public TableLayoutPanel table;
		public List<GameObject> GameObjects = new();
		public Color[] Colors = new Color[]
		{Color.Red, Color.Brown, Color.Black, Color.Blue, Color.Crimson, Color.Gold, Color.Chocolate, 
			Color.Magenta, Color.Pink, Color.Sienna, Color.Red, Color.LightBlue, Color.Coral, Color.Aqua, 
			Color.Orange,Color.YellowGreen, Color.Teal, Color.BurlyWood};
		public Level()
		{
			InitializeComponent();
			WindowState = FormWindowState.Maximized;
			FormBorderStyle = FormBorderStyle.Fixed3D;
			MaximizeBox = false;
			List<int> startpositionRow = LevelsList.StartpositionRow;
			List<int> endpositionRow = LevelsList.EndpositionRow;
			List<int> endpositionColumn = LevelsList.EndpositionColumn;
			List<int> startpositionColumn = LevelsList.StartpositionColumn;
			for (int i=0;i<startpositionRow.Count;i++)
            {
				var startposition = new Position(startpositionRow[i], startpositionColumn[i]);
				var endposition = new Position(endpositionRow[i], endpositionColumn[i]);
				if (i == 0) GameObjects.Add(CreateObject(startposition, endposition, GameObjectType.UserObject, CreateDirectionMove(startposition, endposition),0));
				else GameObjects.Add(CreateObject(startposition, endposition, WhatObjectType(startposition,endposition), CreateDirectionMove(startposition, endposition),i));				
			}
			KeyPreview = true;       			
			table = new TableLayoutPanel();			
			for (int i = 0; i < SizeField; i++)
			{
				table.RowStyles.Add(new RowStyle(SizeType.Percent, 1000f / SizeField));
				table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3000f / SizeField));
			}
			for (int column = 0; column < SizeField; column++)
				for (int row = 0; row < SizeField; row++)
				{
					var button = new Button();
					button.BackColor = Color.White;
					button.Dock = DockStyle.Fill;
					if((row==2 || row == 3) && column == 6)
                    {
                        button.BackgroundImage = Image.FromFile("exit.png");
                        button.BackgroundImageLayout = ImageLayout.Zoom;
                        button.BackColor = Color.Green;
                    }
					button.Click += new System.EventHandler(HandleClick);
					table.Controls.Add(button, column, row);
				}
			table.Dock = DockStyle.Fill;
			Controls.Add(table);			
			KeyUp += OnKeyDown;
			FormClosing += Form1_Closing;
			Redraw();
		}
		public GameObject CreateObject(Position startPosition, Position endPosition, GameObjectType gameObjectType, Direction[] directions, int i)
        {
			var random = new Random();
			var objectcolor = Color.Green;
			if (GameObjectType.UserObject != gameObjectType)
			{
				objectcolor = Colors[i];
				objectcolor = objectcolor == Color.White ? Color.Pink:objectcolor;
			}
			return new GameObject(startPosition, endPosition, gameObjectType, directions, objectcolor);
        }
		public Direction[] CreateDirectionMove(Position startPosition, Position endPosition)
		{

			if (startPosition.row + 1 == endPosition.row && startPosition.column + 1 == endPosition.column) 
				return new Direction[] { Direction.UP, Direction.DOWN, Direction.LEFT, Direction.RIGHT };
			else if (startPosition.row + 1 == endPosition.row || startPosition.row + 2 == endPosition.row) 
				return new Direction[] { Direction.UP, Direction.DOWN };
			else return new Direction[] { Direction.LEFT, Direction.RIGHT };

		}
		public static GameObjectType WhatObjectType(Position startPosition, Position endPosition)
        {
			if (startPosition.row + 1 == endPosition.row && startPosition.column + 1 == endPosition.column) return GameObjectType.NotUserObject;
			else if (startPosition.row + 1 == endPosition.row || startPosition.row + 2 == endPosition.row) return GameObjectType.DownObject;
			else return GameObjectType.RightObject;
		}
		private void HandleClick(object sender, EventArgs e)
		{
			var position = table.GetCellPosition((Control)sender);
			foreach (var obj in GameObjects)
			{
				if (position.Row >= obj.startPosition.row && position.Row <= obj.endPosition.row)
				{
					if (position.Column >= obj.startPosition.column && position.Column <= obj.endPosition.column)
					{
						SelectObject = obj;
						return;
					}
				}
			}
		}
		private void OnKeyDown(object sender, KeyEventArgs e)
		{
			if (SelectObject != null)
			{
				switch (e.KeyCode)
				{
					case Keys.Up:
						{
							MakeMove(SelectObject, Direction.UP);
							break;
						}
					case Keys.Down:
						{
							MakeMove(SelectObject, Direction.DOWN);
							break;
						}
					case Keys.Right:
						{
							MakeMove(SelectObject, Direction.RIGHT);
							break;
						}
					case Keys.Left:
						{
							MakeMove(SelectObject, Direction.LEFT);
							break;
						}
				}
				Redraw();
			}
            if (SelectObject.type == GameObjectType.UserObject && SelectObject.startPosition.row == 2 && SelectObject.startPosition.column == 5)
            {
                LevelsList.Levelnumber = 0;
                var menu = new Menu();
				Hide();
                menu.Show();
            }
        }
		private void Redraw()
		{
			ClearField();
			if(GameObjects.Count!=0) DrawField(GameObjects);
		}
		public void ClearField()
		{
			foreach (var cell in table.Controls)
			{
				if (cell is Button button)
				{
					button.BackColor = Color.White;
					button.Text = null;
				}
			}
		}
		private void DrawField(List<GameObject> objects)
		{
			ClearField();
			foreach (var obj in objects)
			{
				for (var i = obj.startPosition.column; i <= obj.endPosition.column; i++)
				{
					for (var j = obj.startPosition.row; j <= obj.endPosition.row; j++)
					{
						((Button)table.Controls[i * SizeField + j]).BackColor = obj.Color;
						if (obj.type == GameObjectType.UserObject)
						{
							((Button)table.Controls[i * SizeField + j]).Text = "You";
							((Button)table.Controls[i * SizeField + j]).Font = new Font("Arial", 26);
						}
					}
				}
			}
		}
		private void MakeMove(GameObject obj, Direction direction)
		{
			if (!CanMoveThisDirection(direction, obj.moveDirections))
			{
				return;
			}

			var newStartPosition = new Position(obj.startPosition.row, obj.startPosition.column);
			var newEndPosition = new Position(obj.endPosition.row, obj.endPosition.column);

			switch (direction)
			{
				case Direction.UP:
					{
						if(obj.startPosition.row-1>=0)
                        {
							newStartPosition.row = obj.startPosition.row - 1;
							newEndPosition.row = obj.endPosition.row - 1;
						}					
						break;
					}
				case Direction.DOWN:
					{
						if (obj.endPosition.row + 1 < SizeField)
                        {
							newStartPosition.row = obj.startPosition.row + 1;
							newEndPosition.row = obj.endPosition.row + 1;
						}						
						break;
					}
				case Direction.RIGHT:
					{
						if (obj.endPosition.column + 1 < SizeField)
                        {
							newStartPosition.column = obj.startPosition.column + 1;
							newEndPosition.column = obj.endPosition.column + 1;
						}
						break;
					}
				case Direction.LEFT:
					{
						if (obj.startPosition.column - 1 >= 0)
                        {
							newStartPosition.column = obj.startPosition.column - 1;
							newEndPosition.column = obj.endPosition.column - 1;
						}					
						break;
					}
			}
			if (GameObjects.Count != 0)
			{
				foreach (var e in GameObjects)
				{
					if (obj.Equals(e))
					{
						continue;
					}

					if (IsColliding(newStartPosition, newEndPosition, e.startPosition, e.endPosition))
					{
						return;
					}
				}
			}

			obj.startPosition = newStartPosition;
			obj.endPosition = newEndPosition;
		}
		private bool CanMoveThisDirection(Direction direction, Direction[] allowedDirections)
		{
			foreach ( var dir in allowedDirections)
			{
				if (dir == direction)
				{
					return true;
				}
			}
			return false;
		}		
		private bool IsInsideSegment(int point, int segmentStart, int segmentEnd)
		{
			return point >= segmentStart && point <= segmentEnd;
		}
		private bool IsColliding(Position firstStart, Position firstEnd, Position secondStart, Position secondEnd)
		{
			/*
													Column
					┌───────────────────────────────────────►
					│
					│ FirstStart
					│   ┌─────────────────┐
					│   │                 │  SecondStart
					│   │                 │     ┌─┐
					│   │                 │     │ │
					│   │                 │     │ │
					│   └─────────────────┘     │ │
					│                FirstEnd   │ │
					│                           │ │
					│                           └─┘
			   Row  │                              SecondEnd
					▼
			*/
			bool isColumnCollision = IsInsideSegment(secondStart.column, firstStart.column, firstEnd.column) ||
                                     IsInsideSegment(secondEnd.column, firstStart.column, firstEnd.column) ||
                                     IsInsideSegment(firstStart.column, secondStart.column, secondEnd.column) ||
                                     IsInsideSegment(firstEnd.column, secondStart.column, secondEnd.column);
			
			bool isRowCollision = IsInsideSegment(secondStart.row, firstStart.row, firstEnd.row) ||
                                  IsInsideSegment(secondEnd.row, firstStart.row, firstEnd.row) ||
                                  IsInsideSegment(firstStart.row, secondStart.row, secondEnd.row) ||
                                  IsInsideSegment(firstEnd.row, secondStart.row, secondEnd.row);

			return isColumnCollision && isRowCollision;
		}
		private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
			var menu = new Menu();
			menu.Show();
        }
	}
}
