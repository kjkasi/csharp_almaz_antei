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
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    str += $"{items[i, j]} \t";
                }
                str += "\n";
            }

            return str;
        }
    }
}
