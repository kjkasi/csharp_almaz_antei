using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestStepsToANumber
{
    class Program
    {
        static int Test(int number)
        {
            int result = 0;
            int num = number;

            for (int i = 0; num > 1; i++)
            {
                if (num % 2 == 0)
                {
                    num /= 2;
                }
                else
                {
                    num -= 1;
                }
                result += 1;
            }

            return result;
        }
        static void Main(string[] args)
        {
            Test(1);
            Test(12);
            Test(16);
            Test(71);
            Console.ReadKey();
        }
    }
}
