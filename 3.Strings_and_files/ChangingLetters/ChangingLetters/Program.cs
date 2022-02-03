using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangingLetters
{
    class Program
    {
        static string Test(string s)
        {
            string result = s;
            for (int i = 0; i < result.Length; i++)
            {
                string str = result.Substring(i, 1);
                if (str == "a" ||
                    str == "e" ||
                    str == "i" ||
                    str == "o" ||
                    str == "u")
                {
                    string uStr = str.ToUpper();
                    result = result.Replace(str, uStr);
                    //result[i] = result[i].;
                    //Console.WriteLine(result);
                }
            }

            return result;
        }
        static void Main(string[] args)
        {
            Test("Hello world");
            Console.ReadKey();
        }
    }
}
