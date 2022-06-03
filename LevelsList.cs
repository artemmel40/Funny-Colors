using System.Collections.Generic;

namespace Zoo
{
    public class LevelsList
    {
        public static List<int> StartpositionRow = new();
        public static List<int> EndpositionRow = new();
        public static List<int> EndpositionColumn = new();
        public static List<int> StartpositionColumn = new();
        public static int Levelnumber;
        public LevelsList(int Levelnumber)
        {
            // first Object is User!!!
            if(Levelnumber==0)//test+
            {
                var startpositionRow = new List<int> {0,3,4,0,4};
                var startpositionColumn = new List<int> { 2, 2, 0, 5, 5 };
                var endpositionRow = new List<int> { 1,3,5,2,4 };
                var endpositionColumn = new List<int> { 3,4,1,5,6 };
                CreateLevel(startpositionRow, startpositionColumn, endpositionRow, endpositionColumn);

            }
            else if (Levelnumber==1)//2+
            {
                var startpositionRow = new List<int> { 5, 1, 0, 0, 2, 3, 3, 2, 4, 4, 5 };
                var startpositionColumn = new List<int> { 2, 1, 3, 5, 1, 2, 4, 6, 3, 5, 5 };
                var endpositionRow = new List<int> { 6, 1, 2, 0, 3, 3, 3, 3, 4, 4, 6 };
                var endpositionColumn = new List<int> { 3, 2, 3, 6, 1, 3, 5, 6, 4, 6, 6 };
                CreateLevel(startpositionRow, startpositionColumn, endpositionRow, endpositionColumn);
            }
            else if (Levelnumber==2)//3+
            {
                var startpositionRow = new List<int> { 2, 1, 1, 1, 3, 3, 2, 4, 4, 4, 5 };
                var startpositionColumn = new List<int> { 4, 0, 3, 6, 0, 1, 3, 1, 2, 4, 4 };
                var endpositionRow = new List<int> { 3, 2, 1, 3, 5, 3, 4, 5, 5, 4, 5 };
                var endpositionColumn = new List<int> { 5, 1, 5, 6, 0, 2, 3, 1, 2, 6, 5 };
                CreateLevel(startpositionRow, startpositionColumn, endpositionRow, endpositionColumn);
            }
            else if (Levelnumber == 3)//4+
            {
                var startpositionRow = new List<int> { 4, 2, 0, 1, 3, 4, 5, 5, 6, 6 };
                var startpositionColumn = new List<int> { 0, 0, 3, 4, 3, 5, 2, 4, 1, 3 };
                var endpositionRow = new List<int> { 5, 3, 2, 2, 4, 4, 5, 5, 6, 6 };
                var endpositionColumn = new List<int> { 1, 0, 3, 5, 3, 6, 3, 5, 2, 4 };
                CreateLevel(startpositionRow, startpositionColumn, endpositionRow, endpositionColumn);
            }
            else if (Levelnumber == 4)//5+
            {
                var startpositionRow = new List<int> { 3, 0, 0, 0, 2, 1, 3, 4, 4, 6, 5 };
                var startpositionColumn = new List<int> { 4, 1, 2, 5, 0, 3, 2, 0, 2, 1, 4 };
                var endpositionRow = new List<int> { 4, 1, 0, 2, 3, 2, 3, 6, 5, 6, 6 };
                var endpositionColumn = new List<int> { 5, 1, 4, 5, 1, 3, 3, 0, 2, 3, 4 };
                CreateLevel(startpositionRow, startpositionColumn, endpositionRow, endpositionColumn);
            }
            else if (Levelnumber == 5)//6+
            {
                var startpositionRow = new List<int> { 3, 2, 1, 2, 3, 3, 5, 5, 5 };
                var startpositionColumn = new List<int> { 1, 0, 3, 5, 3, 5, 0, 3, 5 };
                var endpositionRow = new List<int> { 4, 2, 2, 2, 4, 4, 5, 6, 5 };
                var endpositionColumn = new List<int> { 2, 1, 3, 6, 4, 5, 1, 3, 6 };
                CreateLevel(startpositionRow, startpositionColumn, endpositionRow, endpositionColumn);
            }
            else if (Levelnumber == 6)//7+
            {
                var startpositionRow = new List<int> { 4, 1, 0, 0, 1, 1, 3, 3, 4, 4, 6, 5 };
                var startpositionColumn = new List<int> { 0, 0, 1, 4, 3, 6, 1, 4, 3, 6, 1, 4 };
                var endpositionRow = new List<int> { 5, 2, 1, 0, 2, 2, 3, 3, 5, 5, 6, 6 };
                var endpositionColumn = new List<int> { 1, 0, 2, 5, 3, 6, 2, 5, 3, 6, 2, 5 };
                CreateLevel(startpositionRow, startpositionColumn, endpositionRow, endpositionColumn);
            }
            else if (Levelnumber == 7)//8+
            {
                var startpositionRow = new List<int> { 0, 0, 2, 1, 2, 3, 3, 6, 6 };
                var startpositionColumn = new List<int> { 0, 3, 1, 3, 5, 3, 4, 2, 4 };
                var endpositionRow = new List<int> { 1, 0, 2, 2, 2, 5, 5, 6, 6 };
                var endpositionColumn = new List<int> { 1, 5, 2, 4, 6, 3, 4, 3, 5 };
                CreateLevel(startpositionRow, startpositionColumn, endpositionRow, endpositionColumn);
            }
            else if (Levelnumber == 8)//9+
            {
                var startpositionRow = new List<int> { 3, 4, 2, 1, 0, 1, 2, 4, 4, 4, 5, 6 };
                var startpositionColumn = new List<int> { 2, 0, 1, 2, 3, 4, 5, 4, 5, 0, 2, 3 };
                var endpositionRow = new List<int> { 4, 4, 3, 2, 1, 3, 3, 5, 4, 4, 6, 6 };
                var endpositionColumn = new List<int> { 3, 1, 1, 2, 3, 4, 5, 4, 6, 1, 2, 4 };
                CreateLevel(startpositionRow, startpositionColumn, endpositionRow, endpositionColumn);
            }
            else if (Levelnumber == 9)//10+
            {
                var startpositionRow = new List<int> { 5, 2, 1, 1, 3, 2, 2, 4, 4 };
                var startpositionColumn = new List<int> { 0, 2, 3, 4, 3, 5, 6, 3, 4 };
                var endpositionRow = new List<int> { 6, 4, 2, 1, 3, 3, 4, 5, 5 };
                var endpositionColumn = new List<int> { 1, 2, 3, 5, 4, 5, 6, 3, 5 };
                CreateLevel(startpositionRow, startpositionColumn, endpositionRow, endpositionColumn);
            }
            else if (Levelnumber == 10)//11+
            {
                var startpositionRow = new List<int> { 4, 0, 0, 2, 2, 2, 4, 4, 6 };
                var startpositionColumn = new List<int> { 0, 0, 2, 0, 3, 5, 2, 3, 0 };
                var endpositionRow = new List<int> { 5, 1, 1, 2, 3, 3, 5, 4, 6 };
                var endpositionColumn = new List<int> { 1, 1, 2, 2, 4, 5, 2, 5, 2 };
                CreateLevel(startpositionRow, startpositionColumn, endpositionRow, endpositionColumn);
            }
            else if (Levelnumber == 11)//12+
            {
                var startpositionRow = new List<int> { 2, 0, 1, 3, 3, 5, 4, 5, 4 };
                var startpositionColumn = new List<int> { 2, 3, 5, 0, 4, 1, 3, 4, 5 };
                var endpositionRow = new List<int> { 3, 1, 2, 4, 3, 5, 6, 6, 4 };
                var endpositionColumn = new List<int> { 3, 4, 5, 1, 6, 2, 3, 4, 6 };
                CreateLevel(startpositionRow, startpositionColumn, endpositionRow, endpositionColumn);
            }
            else if (Levelnumber == 12)//13+
            {
                var startpositionRow = new List<int> { 1, 0, 0, 1, 1, 3, 4, 4, 3, 5, 6, 6 };
                var startpositionColumn = new List<int> { 1, 0, 4, 4, 6, 1, 3, 4, 6, 0, 2, 4 };
                var endpositionRow = new List<int> { 2, 0, 0, 3, 2, 3, 5, 5, 4, 6, 6, 6 };
                var endpositionColumn = new List<int> { 2, 2, 5, 4, 6, 3, 3, 5, 6, 0, 3, 6 };
                CreateLevel(startpositionRow, startpositionColumn, endpositionRow, endpositionColumn);
            }
            else if (Levelnumber == 13)//14+
            {
                var startpositionRow = new List<int> { 3, 0, 0, 1, 2, 2, 5, 3, 4 };
                var startpositionColumn = new List<int> { 1, 0, 3, 5, 0, 1, 0, 3, 5 };
                var endpositionRow = new List<int> { 4, 0, 0, 2, 4, 2, 5, 5, 5 };
                var endpositionColumn = new List<int> { 2, 1, 4, 5, 0, 3, 2, 3, 5 };
                CreateLevel(startpositionRow, startpositionColumn, endpositionRow, endpositionColumn);
            }
            else if (Levelnumber == 14)//15+
            {
                var startpositionRow = new List<int> { 5, 0, 0, 2, 1, 1, 4, 3, 3, 2, 3, 3, 5 };
                var startpositionColumn = new List<int> { 1, 0, 2, 0, 1, 6, 0, 1, 3, 4, 5, 6, 4 };
                var endpositionRow = new List<int> { 6, 0, 0, 3, 2, 2, 5, 3, 5, 4, 4, 5, 6 };
                var endpositionColumn = new List<int> { 2, 1, 3, 0, 2, 6, 0, 2, 3, 4, 5, 6, 5 };
                CreateLevel(startpositionRow, startpositionColumn, endpositionRow, endpositionColumn);
            }
            else if (Levelnumber == 15)//16+
            {
                var startpositionRow = new List<int> { 4, 0, 0, 1, 2, 3, 3, 2, 4, 3, 6, 5, 5 };
                var startpositionColumn = new List<int> { 0, 1, 3, 2, 1, 2, 0, 3, 3, 5, 1, 3, 4 };
                var endpositionRow = new List<int> { 5, 0, 0, 1, 2, 5, 3, 3, 4, 5, 6, 6, 6 };
                var endpositionColumn = new List<int> { 1, 2, 4, 3, 2, 2, 1, 4, 4, 5, 2, 3, 4 };
                CreateLevel(startpositionRow, startpositionColumn, endpositionRow, endpositionColumn);
            }
            else if (Levelnumber == 16)//17+
            {
                var startpositionRow = new List<int> { 5, 1, 1, 2, 2, 3, 4, 4, 5, 6, 5, 5 };
                var startpositionColumn = new List<int> { 0, 0, 3, 0, 1, 3, 1, 3, 2, 3, 5, 6 };
                var endpositionRow = new List<int> { 6, 1, 2, 4, 3, 3, 4, 4, 5, 6, 6, 6 };
                var endpositionColumn = new List<int> { 1, 2, 3, 0, 2, 4, 2, 5, 4, 4, 5, 6 };
                CreateLevel(startpositionRow, startpositionColumn, endpositionRow, endpositionColumn);
            }
            else if (Levelnumber == 17)//18+
            {
                var startpositionRow = new List<int> { 2, 0, 1, 0, 0, 4, 3, 3, 5, 5, 5 };
                var startpositionColumn = new List<int> { 1, 0, 1, 3, 5, 3, 3, 6, 0, 3, 6 };
                var endpositionRow = new List<int> { 3, 1, 1, 1, 1, 4, 3, 4, 6, 6, 6 };
                var endpositionColumn = new List<int> { 2, 0, 2, 3, 6, 5, 5, 6, 1, 3, 6 };
                CreateLevel(startpositionRow, startpositionColumn, endpositionRow, endpositionColumn);
            }
            else if (Levelnumber == 18)//19+
            {
                var startpositionRow = new List<int> { 5, 0, 1, 2, 2, 4, 4, 5, 5, 5, 5 };
                var startpositionColumn = new List<int> { 1, 0, 1, 0, 3, 1, 3, 0, 3, 4, 6 };
                var endpositionRow = new List<int> { 6, 1, 1, 2, 2, 4, 4, 6, 6, 6, 6 };
                var endpositionColumn = new List<int> { 2, 0, 3, 2, 4, 2, 4, 0, 3, 5, 6 };
                CreateLevel(startpositionRow, startpositionColumn, endpositionRow, endpositionColumn);
            }
            else if (Levelnumber == 19)//20+
            {
                var startpositionRow = new List<int> { 4, 1, 1, 0, 3, 2, 6, 5, 3, 6 };
                var startpositionColumn = new List<int> { 4, 1, 2, 5, 0, 3, 0, 3, 6, 4 };
                var endpositionRow = new List<int> { 5, 2, 1, 1, 3, 4, 6, 6, 5, 6 };
                var endpositionColumn = new List<int> { 5, 1, 3, 6, 2, 3, 1, 3, 6, 6 };
                CreateLevel(startpositionRow, startpositionColumn, endpositionRow, endpositionColumn);
            }
            else if (Levelnumber == 20)//21+
            {
                var startpositionRow = new List<int> { 5, 0, 2, 2, 2, 2, 1, 4, 3, 3, 4, 2, 5 };
                var startpositionColumn = new List<int> { 2, 2, 0, 1, 2, 4, 5, 0, 2, 3, 4, 6, 5 };
                var endpositionRow = new List<int> { 6, 1, 3, 3, 2, 3, 1, 4, 4, 4, 4, 4, 5 };
                var endpositionColumn = new List<int> { 3, 3, 0, 1, 3, 5, 6, 1, 2, 3, 5, 6, 6 };
                CreateLevel(startpositionRow, startpositionColumn, endpositionRow, endpositionColumn);
            }
            else if (Levelnumber == 21)//22+
            {
                var startpositionRow = new List<int> { 5, 1, 1, 2, 2, 3, 4, 4, 3, 4, 5, 4 };
                var startpositionColumn = new List<int> { 1, 1, 4, 1, 2, 0, 1, 3, 4, 4, 4, 6 };
                var endpositionRow = new List<int> { 6, 1, 2, 3, 3, 5, 4, 5, 3, 4, 6, 5 };
                var endpositionColumn = new List<int> { 2, 3, 4, 1, 3, 0, 2, 3, 5, 5, 5, 6 };
                CreateLevel(startpositionRow, startpositionColumn, endpositionRow, endpositionColumn);
            }
            else if (Levelnumber == 22)//23+
            {
                var startpositionRow = new List<int> { 5, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6 };
                var startpositionColumn = new List<int> { 5, 1, 2, 4, 6, 5, 4, 3, 2, 1, 3 };
                var endpositionRow = new List<int> { 6, 1, 1, 0, 2, 3, 4, 5, 6, 6, 6 };
                var endpositionColumn = new List<int> { 6, 1, 3, 5, 6, 5, 4, 3, 2, 1, 4 };
                CreateLevel(startpositionRow, startpositionColumn, endpositionRow, endpositionColumn);
            }
            else if (Levelnumber == 23)//24+
            {
                var startpositionRow = new List<int> { 2, 1, 0, 0, 1, 2, 2, 1, 4, 3, 5, 5, 5 };
                var startpositionColumn = new List<int> { 1, 1, 4, 5, 0, 3, 4, 6, 0, 4, 0, 4, 5 };
                var endpositionRow = new List<int> { 3, 1, 1, 0, 3, 4, 2, 2, 4, 4, 6, 6, 6 };
                var endpositionColumn = new List<int> { 2, 3, 4, 6, 0, 3, 5, 6, 2, 5, 1, 4, 5 };
                CreateLevel(startpositionRow, startpositionColumn, endpositionRow, endpositionColumn);
            }
            else if (Levelnumber == 24)//25+
            {
                var startpositionRow = new List<int> { 2, 2, 0, 0, 0, 1, 2, 4, 4, 4, 4 };
                var startpositionColumn = new List<int> { 2, 0, 1, 2, 5, 3, 5, 1, 2, 3, 5 };
                var endpositionRow = new List<int> { 3, 3, 1, 1, 1, 1, 3, 5, 5, 4, 5 };
                var endpositionColumn = new List<int> { 3, 1, 1, 2, 5, 4, 6, 1, 2, 4, 5 };
                CreateLevel(startpositionRow, startpositionColumn, endpositionRow, endpositionColumn);
            }
            else if (Levelnumber == 25)//26+
            {
                var startpositionRow = new List<int> { 0, 1, 0, 2, 2, 2, 5, 5, 4, 4, 5 };
                var startpositionColumn = new List<int> { 0, 2, 5, 1, 4, 5, 0, 2, 2, 5, 4 };
                var endpositionRow = new List<int> { 1, 1, 1, 4, 3, 2, 6, 6, 4, 4, 6 };
                var endpositionColumn = new List<int> { 1, 4, 6, 1, 4, 6, 1, 2, 3, 6, 4 };
                CreateLevel(startpositionRow, startpositionColumn, endpositionRow, endpositionColumn);
            }
            else if (Levelnumber == 26)//27+
            {
                var startpositionRow = new List<int> { 3, 1, 0, 0, 1, 2, 1, 4, 5, 3, 3 };
                var startpositionColumn = new List<int> { 1, 1, 2, 3, 3, 3, 5, 3, 2, 5, 6 };
                var endpositionRow = new List<int> { 4, 2, 2, 0, 1, 3, 2, 4, 5, 5, 4 };
                var endpositionColumn = new List<int> { 2, 1, 2, 5, 4, 4, 6, 4, 4, 5, 6 };
                CreateLevel(startpositionRow, startpositionColumn, endpositionRow, endpositionColumn);
            }
            else if (Levelnumber == 27)//28+
            {
                var startpositionRow = new List<int> { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6 };
                var startpositionColumn = new List<int> { 0, 2, 2, 4, 4, 0, 1, 2, 3, 4, 5, 0, 2 };
                var endpositionRow = new List<int> { 1, 0, 2, 1, 3, 4, 4, 5, 5, 6, 6, 5, 6 };
                var endpositionColumn = new List<int> { 1, 4, 3, 6, 5, 0, 1, 2, 3, 4, 5, 1, 3 };
                CreateLevel(startpositionRow, startpositionColumn, endpositionRow, endpositionColumn);
            }
            else if (Levelnumber == 28)//29+
            {
                var startpositionRow = new List<int> {2,0,0,1,0,2,3,4,6,4,3,4,5  };
                var startpositionColumn = new List<int> {2,0,2,2,4,0,0,0,0,3,4,4,6 };
                var endpositionRow = new List<int> { 3,1,0,1,2,2,3,4,6,5,3,5,6 };
                var endpositionColumn = new List<int> { 3,1,3,3,4,1,1,2,1,3,5,5,6 };
                CreateLevel(startpositionRow, startpositionColumn, endpositionRow, endpositionColumn);
            }
            else if (Levelnumber == 29)//30+
            {
                var startpositionRow = new List<int> {2,1,1,2,3,2,4,4,5,6,4};
                var startpositionColumn = new List<int> {0,2,4,2,3,5,1,2,2,2,5};
                var endpositionRow = new List<int> {3,1,2,3,3,3,6,4,5,6,6};
                var endpositionColumn = new List<int> {1,3,4,2,4,6,1,4,4,4,5};
                CreateLevel(startpositionRow, startpositionColumn, endpositionRow, endpositionColumn);
            }
            else if (Levelnumber == 30)//31+
            {
                var startpositionRow = new List<int> {5,0,0,1,1,2,3,5,4,6,4 };
                var startpositionColumn = new List<int> {0,0,4,0,2,5,0,2,3,4,6 };
                var endpositionRow = new List<int> {6,0,1,2,3,2,4,6,4,6,6 };
                var endpositionColumn = new List<int> {1,2,4,0,2,6,1,3,5,5,6 };
                CreateLevel(startpositionRow, startpositionColumn, endpositionRow, endpositionColumn);
            }
            else if (Levelnumber == 31)//32+
            {
                var startpositionRow = new List<int> {1,3,4,5,0,0,3,1,1 };
                var startpositionColumn = new List<int> { 0,0,1,2,4,3,3,4,6};
                var endpositionRow = new List<int> { 2,3,4,6,0,2,3,2,3};
                var endpositionColumn = new List<int> {1,1,3,2,6,3,5,5,6 };
                CreateLevel(startpositionRow, startpositionColumn, endpositionRow, endpositionColumn);
            }
            else if (Levelnumber == 32)//33+
            {
                var startpositionRow = new List<int> {2,0,0,0,0,3,4,3,4,4,6 };
                var startpositionColumn = new List<int> { 2,0,2,3,5,0,0,4,2,4,2};
                var endpositionRow = new List<int> {3,2,1,1,2,3,4,3,5,4,6 };
                var endpositionColumn = new List<int> {3,0,2,3,5,1,1,5,3,5,3 };
                CreateLevel(startpositionRow, startpositionColumn, endpositionRow, endpositionColumn);
            }
            else if (Levelnumber == 33)//34+
            {
                var startpositionRow = new List<int> {3,0,0,0,2,1,2,1,2,3,3,5,6 };
                var startpositionColumn = new List<int> {0,0,1,3,0,2,3,5,6,2,3,1,2 };
                var endpositionRow = new List<int> {4,1,0,1,2,2,2,3,4,4,4,5,6 };
                var endpositionColumn = new List<int> {1,0,2,4,1,2,4,5,6,2,4,3,4 };
                CreateLevel(startpositionRow, startpositionColumn, endpositionRow, endpositionColumn);
            }
            else if (Levelnumber == 34)//35+
            {
                var startpositionRow = new List<int> {4,0,0,0,0,0,2,3,2,4,4,4,5 };
                var startpositionColumn = new List<int> {0,0,1,2,4,5,0,0,4,2,3,4,4 };
                var endpositionRow = new List<int> {5,1,1,1,1,1,2,3,3,5,5,4,5 };
                var endpositionColumn = new List<int> {1,0,1,3,4,5,1,1,5,2,3,5,5 };
                CreateLevel(startpositionRow, startpositionColumn, endpositionRow, endpositionColumn);
            }
            else if (Levelnumber == 35)//36+
            {
                var startpositionRow = new List<int> {4,0,0,2,2,1,3,3,4,3,6,5,5,4 };
                var startpositionColumn = new List<int> {0,3,4,2,4,5,0,2,3,5,0,3,4,6 };
                var endpositionRow = new List<int> {5,1,0,2,3,2,3,4,4,3,6,6,6,6 };
                var endpositionColumn = new List<int> {1,3,6,3,4,6,1,2,4,6,2,3,5,6 };
                CreateLevel(startpositionRow, startpositionColumn, endpositionRow, endpositionColumn);
            }
            else if (Levelnumber == 36)//37+
            {
                var startpositionRow = new List<int> { 5, 0, 0, 1, 1, 2, 4, 4, 3, 6 };
                var startpositionColumn = new List<int> { 3, 0, 5, 0, 3, 4, 0, 2, 5, 0 };
                var endpositionRow = new List<int> { 6, 0, 0, 2, 3, 2, 5, 4, 5, 6 };
                var endpositionColumn = new List<int> { 4, 1, 6, 1, 3, 6, 0, 4, 5, 1 };
                CreateLevel(startpositionRow, startpositionColumn, endpositionRow, endpositionColumn);
            }
            else if (Levelnumber == 37)//38+
            {
                var startpositionRow = new List<int> {0,0,0,0,2,1,2,1,3,4,5,6,4,6,3,4 };
                var startpositionColumn = new List<int> {1,0,4,5,2,3,4,6,4,2,2,0,5,5,1,0 };
                var endpositionRow = new List<int> {1,1,1,0,3,3,2,2,3,4,5,6,5,6,5,5 };
                var endpositionColumn = new List<int> {2,0,4,6,2,3,5,6,5,4,3,2,6,6,1,0 };
                CreateLevel(startpositionRow, startpositionColumn, endpositionRow, endpositionColumn);
            }
            else if (Levelnumber == 38)//39+
            {
                var startpositionRow = new List<int> {1,1,5,0,0,0,0,3,4,5,2,5,0 };
                var startpositionColumn = new List<int> {1,0,0,3,4,5,6,0,0,2,5,5,1 };
                var endpositionRow = new List<int> {2,2,6,1,1,1,1,3,4,5,4,6,0 };
                var endpositionColumn = new List<int> {2,0,1,3,4,5,6,1,1,4,5,6,2 };
                CreateLevel(startpositionRow, startpositionColumn, endpositionRow, endpositionColumn);
            }
            else if (Levelnumber == 39)//40
            {
                var startpositionRow = new List<int> {3,0,1,2,3,5,0,1,2,4,5,6,4,2 };
                var startpositionColumn = new List<int> {4,3,2,1,0,0,4,5,6,2,4,2,6,3 };
                var endpositionRow = new List<int> {4,1,3,3,4,6,2,2,3,5,6,6,6,3 };
                var endpositionColumn = new List<int> {5,3,2,1,0,0,4,5,6,3,5,3,6,3 };
                CreateLevel(startpositionRow, startpositionColumn, endpositionRow, endpositionColumn);
            }
            void CreateLevel(List<int> startPositionRow, List<int> startPositionColumn, List<int> endPositionRow, List<int> endPositionColumn)
            {
                StartpositionRow = startPositionRow;
                StartpositionColumn = startPositionColumn;
                EndpositionRow = endPositionRow;
                EndpositionColumn = endPositionColumn;
            }

            var level = new Level();
            level.Show();
        }
    }
}