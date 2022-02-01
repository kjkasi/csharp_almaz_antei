using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedNumber
{
    class Program
    {

        static string Test(int num)
        {
            string resultString = "Balanced";
            string numString = num.ToString();

            if (numString.Length > 1)
            {
                //string midString;
                string leftString = "";
                string rightString = "";

                if (numString.Length % 2 == 0)
                {
                    //Если четная
                    //Console.WriteLine($"{num} четная");
                    int leftLength = (int)Math.Floor(numString.Length / 2.0);
                    leftString = numString.Substring(0, leftLength - 1);

                    int rightStart = (int)Math.Ceiling(numString.Length / 2.0);
                    rightString = numString.Substring(rightStart + 1, numString.Length - (rightStart + 1));
                }
                else
                {
                    //Если нечетная
                    //Console.WriteLine($"{num} не четная");
                    //double test = numString.Length / 2.0;
                    //int index = (int)Math.Ceiling(test);
                    //midString = numString.Substring(index, 1);
                    //double test = numString.Length / 2.0;
                    //double test2 = Math.Floor(test);
                    int leftLength = (int)Math.Floor(numString.Length / 2.0);
                    leftString = numString.Substring(0, leftLength);

                    int rightStart = (int)Math.Ceiling(numString.Length / 2.0);
                    rightString = numString.Substring(rightStart, numString.Length - rightStart);
                    //Console.WriteLine(leftString);
                }

                int sumLeft = 0;

                for (int i = 0; i < leftString.Length; i++)
                {
                    string subString = leftString.Substring(i, 1);
                    int int1 = Convert.ToInt32(subString);
                    sumLeft = sumLeft + int1;
                }

                int sumRight = 0;

                for (int i = 0; i < rightString.Length; i++)
                {
                    string subString = rightString.Substring(i, 1);
                    int int1 = Convert.ToInt32(subString);
                    sumRight = sumRight + int1;
                }

                if (sumLeft != sumRight)
                {
                    resultString = "Not Balanced";
                }

            }

            Console.WriteLine(numString);
            Console.WriteLine(resultString);
            Console.WriteLine();

            return resultString;
        }

        static void Main(string[] args)
        {
            Test(7);
            Test(295591);
            Test(959);
            Test(27102983);
            Console.ReadKey();
        }
    }
}
