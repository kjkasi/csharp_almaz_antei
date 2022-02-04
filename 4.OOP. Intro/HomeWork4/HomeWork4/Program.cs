using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class FractionNumber
    {
        public int numerator;
        public int denominator;
        public string number;
        public FractionNumber(int numerator = 0, int denominator = 0)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public string Show()
        {
            return $"{numerator},{denominator}";
        }

        public static double Addition(FractionNumber a, FractionNumber b)
        {
            string strA = a.Show();
            string strB = b.Show();
            double numA = double.Parse(strA);
            double numB = double.Parse(strB);
            return numA + numB;
        }

        public static double Subtraction(FractionNumber a, FractionNumber b)
        {
            double numA = double.Parse(a.Show());
            double numB = double.Parse(b.Show());
            return numA - numB;
        }
        public static double Multiplication(FractionNumber a, FractionNumber b)
        {
            double numA = double.Parse(a.Show());
            double numB = double.Parse(b.Show());
            return numA * numB;
        }
        public static double Devision(FractionNumber a, FractionNumber b)
        {
            double numA = double.Parse(a.Show());
            double numB = double.Parse(b.Show());
            return numA / numB;
        }
        public static bool Comparison(FractionNumber a, FractionNumber b)
        {
            double numA = double.Parse(a.Show());
            double numB = double.Parse(b.Show());
            return numA == numB ? true : false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FractionNumber numA = new FractionNumber(1, 1);
            FractionNumber numB = new FractionNumber(2, 1);
            Console.WriteLine(numA.Show());
            Console.WriteLine(numB.Show());
            Console.WriteLine(FractionNumber.Addition(numA, numB));
            Console.WriteLine(FractionNumber.Subtraction(numA, numB));
            Console.WriteLine(FractionNumber.Multiplication(numA, numB));
            Console.WriteLine(FractionNumber.Devision(numA, numB));

            Console.ReadKey();
        }
    }
}
