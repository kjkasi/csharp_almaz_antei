using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferenceOf2
{
    class Program
    {
        static (int, int)[] Task(int[] numbers)
        {
            int rows = 0;

            int[] arr = numbers;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int diff = Math.Abs(arr[i] - arr[j]);
                    if (diff == 2)
                    {
                        ++rows;
                    }
                }
            }

            (int, int) [] result = new (int, int) [rows];

            int index = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int diff = Math.Abs(arr[i] - arr[j]);
                    if (diff == 2)
                    {
                        result[index] = (arr[i], arr[j]);
                        index++;
                    }
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            Task(new int[] { 1, 2, 3, 4 });
            Task(new int[] { 4, 1, 2, 3 });
            Task(new int[] { 1, 23, 3, 4, 7 });
            Task(new int[] { 4, 3, 1, 5, 6 });
            Console.ReadKey();
        }
    }
}
