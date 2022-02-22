using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    abstract class Figure
    {
        public delegate bool FigureStateHandler(Figure figure, int newX, int newY);

        public FigureStateHandler del { get; set; }

        public int x { get; set; }

        public int y { get; set; }

        public bool Step(int x, int y)
        {
            bool result = del.Invoke(this, x, y);
            if  (result == true)
            {
                this.x = x;
                this.y = y;
            }
            return result;

        }

        public void RegisterHandler(FigureStateHandler del)
        {
            this.del = del;
        }
    }
}
