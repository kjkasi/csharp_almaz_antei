using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumber
{
    class Program
    {
        static string Test(int num)
        {
            string resultString = "Special!!";
            string numString = num.ToString();

            //for (int i = 0; i < numString.Length; i++)
            //{
            //    string subStr = numString.Substring(i, 1);
            //    if (subStr != "0" || subStr != "1" || subStr != "2" || subStr != "3" || subStr != "4" || subStr != "5")
            //    {
            //        resultString = "NOT!!";
            //    }
            //}

            if (numString.Contains("6"))
            {
                resultString = "NOT!!";
            }

            if (numString.Contains("7"))
            {
                resultString = "NOT!!";
            }

            if (numString.Contains("8"))
            {
                resultString = "NOT!!";
            }

            if (numString.Contains("9"))
            {
                resultString = "NOT!!";
            }

            Console.WriteLine(numString);
            Console.WriteLine(resultString);
            Console.WriteLine();

            return resultString;
        }

        static void Main(string[] args)
        {
            Test(2);
            Test(9);
            Test(23);
            Test(39);
            Test(59);
            Test(513);
            Test(709);
            Console.ReadKey();
        }
    }
}
