using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormTheLargest
{
    class Program
    {
        static int Test(int number)
        {
            int result = number;
            string numberString = number.ToString();

            int[] arr = new int[numberString.Length];

            for (int i = 0; i < numberString.Length; i++)
            {
                string subStr = numberString.Substring(i, 1);
                arr[i] = Convert.ToInt32(subStr);
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }

            }

            string arrString = "";

            foreach (int i in arr)
            {
                arrString = arrString + i.ToString();
            }

            Console.WriteLine(Convert.ToInt32(arrString));

            return Convert.ToInt32(arrString);
        }

        static void Main(string[] args)
        {
            Test(7389);
            Test(63729);
            Test(566797);
            Test(17693284);
            Console.ReadKey();
        }
    }
}
