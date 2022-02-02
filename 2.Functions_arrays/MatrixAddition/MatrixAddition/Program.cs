using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixAddition
{
    class Program
    {
        static int[,] Test(int[,] arr1, int[,] arr2)
        {
            //int[,] result = new int[,] {{ 1, 1 }, { 1, 1 }};

            int rows = arr1.GetUpperBound(0) + 1;
            int cols = arr1.Length / rows;

            int[,] result = new int[rows, cols];


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    //Console.Write($"{arr1[i, j]} \n");
                    result[i, j] = arr1[i, j] + arr2[i, j];
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            int[,] arr1 = new int[,] {{ 1, 2, 3 }, { 3, 2, 1 }, { 1, 1, 1 }};
            int[,] arr2 = new int[,] {{ 2, 2, 1 }, { 3, 2, 3 }, { 1, 1, 3 }};
            Test(arr1, arr2);
            Console.ReadKey();
        }
    }
}
