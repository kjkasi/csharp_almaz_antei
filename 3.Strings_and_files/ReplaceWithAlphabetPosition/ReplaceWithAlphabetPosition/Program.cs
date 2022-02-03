using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceWithAlphabetPosition
{
    internal class Program
    {
        static string Test(string text)
        {
            char[] abc = new char[26] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            //{ 'a', "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

            string result = "";

            for (int i = 0; i < text.Length; i++)
            {
                char item = text[i];
                if (char.IsLetter(item))
                {
                   for (int j = 0; j < abc.Length; j++)
                    {
                        char c = abc[j];
                        if (c == char.ToLower(item))
                        {
                            result += $"{j + 1} ";
                        }
                    }
                }
            }

            return result.Trim();
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Test("The sunset sets at twelve o' clock."));
            Console.WriteLine(Test("The narwhal bacons at midnight."));
            Console.ReadKey();
        }
    }
}
