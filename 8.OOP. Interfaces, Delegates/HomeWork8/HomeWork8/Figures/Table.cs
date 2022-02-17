using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8.Figures
{
    class Table
    {
        private Figure[,] items;

        public Table()
        {
            items = new Figure[8, 8];

            Random rnd = new Random();

            //1 bishop
            //2 king
            //3 knight
            //4 pawn
            //5 queen
            //6 rook

            Figure[] arr = { new Bishop(), new King(), new Knight(), new Pawn(), new Queen(), new Rook() };

            foreach (Figure item in arr)
            {
                bool isNull = true;
                while (isNull)
                {
                    int x = rnd.Next(0, 7);
                    int y = rnd.Next(0, 7);

                    if (items[x, y] is null)
                    {
                        isNull = false;
                        items[x, y] = item;
                    }
                }
            }
            
        }
        public int rows
        {
            get
            {
                return items.GetUpperBound(0) + 1;
            }
        }

        public int cols
        {
            get
            {
                return items.GetUpperBound(1) + 1;
            }
        }

        public override string ToString()
        {
            /*string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    str += $"{items[i, j]} \t";
                }
                str += "\n";
            }

            return str;
            */
        }
    }
}
