using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EasyBalanceChecking
{
    class Program
    {
        static string Test(string book)
        {
            //int count = 0;
            double balance = 0;
            double total = 0;
            double average = 0;
            IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };

            string[] lines = book.Split(new char[] { '\n' });
            string[] result = new string[lines.Length + 2];

            for (int i = 0; i < lines.Length; i++)
            {
                string str = lines[i];
                str = str.Replace("!", " ");
                str = str.Replace(":", " ");
                str = str.Replace("=", " ");
                str = str.Trim();
                str = str.Replace(" ", ":");
                str = str.Replace("::::", ":");
                str = str.Replace(":::", ":");
                str = str.Replace("::", ":");

                if (i == 0)
                {
                    balance = double.Parse(str, formatter);
                    result[i] = $"Original Balance: {str}";
                }
                else
                {
                    string[] items = str.Split(new char[] { ':' });

                    double item3 = double.Parse(items[2], formatter);

                    total += item3;

                    balance = balance - item3;

                    result[i] = $"{items[0]} {items[1]} {items[2]} Balance { string.Format("{0:f2}", balance)}".Replace(",", ".");
                }

                if (i == lines.Length - 1)
                {
                    average = total / i;

                    result[i + 1] = $"Total expense  {string.Format("{0:f2}", total)}".Replace(",", "."); ;
                    result[i + 2] = $"Average expense  {string.Format("{0:f2}", average)}".Replace(",", "."); ;

                }
            }

            return String.Join("\n", result);
        }
        static void Main(string[] args)
        {

            string test = Test("1000.00 !=\n125 Market !=:125.45\n126 Hardware = 34.95\n127 Video! 7.45\n128 Book: 14.32\n129 Gasoline::16.10");
            Console.ReadKey();
        }
    }
}
