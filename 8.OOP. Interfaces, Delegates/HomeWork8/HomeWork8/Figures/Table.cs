using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8.Figures
{
    class Table
    {
        private Figure[,] cells;

        public Figure[] figures = { new Bishop(), new Rook(), new Queen(), new Knight(), new King(), new Pawn() };

        public Table()
        {
            cells = new Figure[8, 8];

            Random rnd = new Random();

            foreach(Figure figure in figures)
            {
                bool result = false;
                while (result == false)
                {
                    int x = rnd.Next(0, 7);
                    int y = rnd.Next(0, 7);
                    figure.RegisterHandler(StepHandler);
                    result = figure.Step(x, y);
                }
            }
        }

        public bool StepHandler(Figure figure, int newX, int newY)
        {
            if (cells[newX, newY] is null)
            {
                cells[newX, newY] = figure;
                cells[figure.x, figure.y] = null;
                return true;
            }
            else
            {
                return false;
            }
        }

        public int rows
        {
            get
            {
                return cells.GetUpperBound(0) + 1;
            }
        }

        public int cols
        {
            get
            {
                return cells.GetUpperBound(1) + 1;
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

            string str = "";
            int count = 0;

            foreach (Figure item in figures)
            {
                if (item is null == false)
                {
                    count += 1;
                    str += $"{Array.IndexOf(figures, item)}.{item.ToString()}\n";
                }
            }
            return str;
        }
    }
}
