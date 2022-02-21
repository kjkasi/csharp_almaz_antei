using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    abstract class Figure
    {
        public delegate bool FigureStateHandler(Figure figure, int x, int y);

        public FigureStateHandler del { get; set; }

        public int x { get; set; }

        public int y { get; set; }
        //public int Y
        //{
        //    get { return this.y; }
        //}

        public abstract void Step(int x, int y);

        public void RegisterHendler(FigureStateHandler del)
        {
            this.del = del;
        }
    }
}
