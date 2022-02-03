using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEnds
{
    class Program
    {
        static bool Test(string str, string ending)
        {
            return str.EndsWith(ending) ? true : false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Test("abc", "bc"));
            Console.WriteLine(Test("abc", "d"));
            Console.ReadKey();
        }
    }
}
