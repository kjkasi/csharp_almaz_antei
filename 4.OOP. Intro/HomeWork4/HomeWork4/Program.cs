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
        public FractionNumber(int numerator = 0, int denominator = 0)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public override string ToString()
        {
            return $"{numerator}/{denominator} or {(double)numerator/denominator}";
        }

        public static FractionNumber Addition(FractionNumber fractA, FractionNumber fractB)
        {
            int numerator = fractA.numerator * fractB.denominator + fractB.numerator * fractA.denominator;
            int denominator = fractA.denominator * fractB.denominator;
            return new FractionNumber(numerator, denominator);
        }

        public static FractionNumber Subtraction(FractionNumber fractA, FractionNumber fractB)
        {
            int numerator = fractA.numerator * fractB.denominator - fractB.numerator * fractA.denominator;
            int denominator = fractA.denominator * fractB.denominator;
            return new FractionNumber(numerator, denominator);
        }
        
        public static FractionNumber Multiplication(FractionNumber fractA, FractionNumber fractB)
        {
            int numerator = fractA.numerator * fractB.numerator;
            int denominator = fractA.denominator * fractB.denominator;
            return new FractionNumber(numerator, denominator);
        }

        public static FractionNumber Devision(FractionNumber fractA, FractionNumber fractB)
        {
            int numerator = fractA.numerator / fractB.numerator;
            int denominator = fractA.denominator / fractB.denominator;
            if (denominator == 0)
                throw new DivideByZeroException();
            else
                return new FractionNumber(numerator, denominator);
        }

        public static bool Comparison(FractionNumber fractA, FractionNumber fractB)
        {
            return fractA.numerator * fractB.denominator == fractB.numerator * fractA.denominator;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"1/2 == 3/4 = {FractionNumber.Comparison(new FractionNumber(1, 2), new FractionNumber(3, 4))}");
            Console.WriteLine($"1/2 == 1/2 = {FractionNumber.Comparison(new FractionNumber(1, 2), new FractionNumber(1, 2))}");
            Console.WriteLine($"2/4 + 1/2 = {FractionNumber.Addition(new FractionNumber(2, 4), new FractionNumber(1, 2))}");
            Console.WriteLine($"2/4 - 1/2 = {FractionNumber.Subtraction(new FractionNumber(2, 4), new FractionNumber(1, 2))}");
            Console.WriteLine($"2/4 * 1/2 = {FractionNumber.Multiplication(new FractionNumber(2, 4), new FractionNumber(1, 2))}");
            Console.WriteLine($"2/4 / 1/2 = {FractionNumber.Devision(new FractionNumber(2, 4), new FractionNumber(1, 2))}");;

            Console.ReadKey();
        }
    }
}
