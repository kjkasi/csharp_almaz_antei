using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeWork6
{

    abstract class Figure
    {
        public abstract string FigureType();
        public abstract string FigureName();

        public abstract double Area();
    }

    abstract class Figure2D: Figure
    {
        public abstract double Perimeter();
    }

    abstract class Polygon : Figure2D
    {
        public override string FigureType()
        {
            return "Многоугольники";
        }
    }

    abstract class Quadrangle : Polygon
    {
        public override string FigureType()
        {
            return "Четырехугольники";
        }
    }

    class Square : Quadrangle
    {
        public double sideA;

        public Square(double sideA)
        {
            this.sideA = sideA;
        }

        public override string FigureName()
        {
            return "Квадрат";
        }

        public override double Perimeter()
        {
            return 4 * sideA;
        }

        public override double Area()
        {
            return Math.Pow(sideA, 2);
        }

        public override string ToString()
        {
            return $"{FigureName()}({FigureType()}) a = {sideA}, S = {Area()}, P = {Perimeter()}";
        }
    }

    class Rectangle : Quadrangle
    {
        public double sideA, sideB;

        public Rectangle(double sideA, double sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }

        public override string FigureName()
        {
            return "Прямоугольник";
        }

        public override double Perimeter()
        {
            return 2 * (sideA + sideB);
        }

        public override double Area()
        {
            return sideA * sideB;
        }

        public override string ToString()
        {
            return $"{FigureName()}({FigureType()}) a = {sideA}, b = {sideB}, c = {Area()}, P = {Perimeter()}";
        }
    }

    class Triangle : Polygon
    {
        public double sideA, sideB, sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public override string FigureName()
        {
            return "Треугольник";
        }

        public override double Perimeter()
        {
            return sideA + sideA + sideA;
        }

        public override double Area()
        {
            return (( 1 / 4) * Math.Sqrt(3)) * Math.Pow(sideA, 2);
        }

        public override string ToString()
        {
            return $"{FigureName()}({FigureType()}) a = {sideA}, b = {sideB}, c = {sideC}, S = {Area()}, P = {Perimeter()}";
        }
    }

    abstract class Ellipse : Figure2D
    {
        public double radius;
        public override string FigureType()
        {
            return "Эллипсы";
        }
    }

    class Circle : Ellipse
    {
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override string FigureName()
        {
            return "Круг";
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }

        public override double Area()
        {
            return 2 * Math.PI * Math.Pow(radius, 2);
        }

        public override string ToString()
        {
            return $"{FigureName()}({FigureType()}) r = {radius}, S = {Area()}, P = {Perimeter()}";
        }
    }


    abstract class Figure3D: Figure
    {
        public abstract double Volume();
    }

    abstract class Polyhedron: Figure3D
    {
        public override string FigureType()
        {
            return "Многогранники";
        }
    }

    class Cube: Polyhedron
    {
        public double sideA;

        public Cube(double sideA)
        {
            this.sideA = sideA;
        }

        public override string FigureName()
        {
            return "Куб";
        }

        public override double Area()
        {
            return Math.Pow(sideA, 3);
        }

        public override double Volume()
        {
            return Math.Pow(sideA, 3);
        }

        public override string ToString()
        {
            return $"{FigureName()}({FigureType()}) a = {sideA}, S = {Area()}, V = {Volume()}";
        }
    }

    abstract class Ellipsoid: Figure3D
    {
        public override string FigureType()
        {
            return "Эллипсойды";
        }
    }

    class Sphere: Ellipsoid
    {
        public double radius;

        public Sphere(double radius)
        {
            this.radius = radius;
        }
        
        public override string FigureName()
        {
            return "Шар";
        }

        public override double Area()
        {
            return 4 * (Math.PI * Math.Pow(radius, 2));
        }

        public override double Volume()
        {
            return (4 / 3) * (Math.PI * Math.Pow(radius, 3));
        }

        public override string ToString()
        {
            return $"{FigureName()}({FigureType()}) r = {radius}, S = {Area()}, V = {Volume()}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Square square = new Square(rnd.Next(1, 100));
            Logger.Out(square.ToString());

            Rectangle rect = new Rectangle(rnd.Next(1, 100), rnd.Next(1, 100));
            Logger.Out(rect.ToString());

            Triangle triangle = new Triangle(rnd.Next(1, 100), rnd.Next(1, 100), rnd.Next(1, 100));
            Logger.Out(triangle.ToString());

            Circle circle = new Circle(rnd.Next(1, 100));
            Logger.Out(circle.ToString());

            Cube cube = new Cube(rnd.Next(1, 100));
            Logger.Out(cube.ToString());

            Sphere sphere = new Sphere(rnd.Next(1, 100));
            Logger.Out(sphere.ToString());

            Logger.Out("");
            Logger.Write("Введите n = ");
            int n = int.Parse(Console.ReadLine());

            Figure[] items = new Figure[n];

            for (int i = 0; i < n; i++ )
            {
                int item = rnd.Next(0, 5);

                if (item == 0)
                {
                    items[i] = new Square(rnd.Next(1, 100));
                }
                else if (item == 1)
                {
                    items[i] = new Rectangle(rnd.Next(1, 100), rnd.Next(1, 100));
                }
                else if (item == 2)
                {
                    items[i] = new Triangle(rnd.Next(1, 100), rnd.Next(1, 100), rnd.Next(1, 100));
                }
                else if (item == 3)
                {
                    items[i] = new Circle(rnd.Next(1, 100));
                }
                else if (item == 4)
                {
                    items[i] = new Cube(rnd.Next(1, 100));
                }
                else if (item == 5)
                {
                    items[i] = new Sphere(rnd.Next(1, 100));
                }
                Logger.Out($"{i + 1}. {items[i]}");
            }

            double maxArea = 0;

            foreach(Figure item in items)
            {
                if (item.Area() > maxArea)
                {
                    maxArea = item.Area();
                }
            }

            Logger.Out("");
            Logger.Out($"Самая большая площадь S = {maxArea}");

            Logger.SaveLog(true);

            Console.ReadKey();
        }

        public static class Logger
        {
            public static StringBuilder LogString = new StringBuilder();

            public static void Out(string str)
            {
                Console.WriteLine(str);
                LogString.Append(str).Append(Environment.NewLine);
            }

            public static void Write(string str)
            {
                Console.Write(str);
                LogString.Append(str);

            }

            public static void SaveLog(bool Append = false, string Path = "./Log.txt")
            {
                if (LogString != null && LogString.Length > 0)
                {
                    if (Append)
                    {
                        using (StreamWriter file = System.IO.File.AppendText(Path))
                        {
                            file.Write(LogString.ToString());
                            file.Close();
                            file.Dispose();
                        }
                    }
                    else
                    {
                        using (System.IO.StreamWriter file = new System.IO.StreamWriter(Path))
                        {
                            file.Write(LogString.ToString());
                            file.Close();
                            file.Dispose();
                        }
                    }
                }
            }
        }
    }
}
