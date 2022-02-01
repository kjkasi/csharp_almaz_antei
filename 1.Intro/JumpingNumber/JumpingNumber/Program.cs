using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingNumber
{
    internal class Program
    {
        static string Test(int num)
        {
            string str1 = num.ToString();
            string result = "Jumping!!";

            if (str1.Length > 1)
            {
                for (int i = 1; i < str1.Length; i++)
                {
                    string char1 = str1.Substring(i - 1, 1);
                    string char2 = str1.Substring(i, 1);

                    int int1 = Convert.ToInt32(char1);
                    int int2 = Convert.ToInt32(char2);
                    int compare = Math.Abs(int1 - int2);

                    if (compare != 1)
                    {
                        result = "Not!!";
                    }
                }
            }

            Console.WriteLine(str1);
            Console.WriteLine(result);
            Console.WriteLine();
            //Console.ReadKey();
            return result;
        }

        static void Main(string[] args)
        {
            Test(9);
            Test(79);
            Test(23);
            Test(556847);
            Test(4343456);
            Test(89098);
            Test(32);
            Console.ReadKey();
        }
    }
}
