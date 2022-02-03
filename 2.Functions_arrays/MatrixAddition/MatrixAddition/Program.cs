using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixAddition
{
    class Program
    {
        static int[][] Test(int[][] arr1, int[][] arr2)
        {
            int rows = arr1.GetUpperBound(0) + 1;
            int cols = arr1.Length / rows;

            int[][] result = new int[rows][];


            for (int i = 0; i < arr1.Length; i++)
            {
                int[] arr = new int[arr1[i].Length];
                for (int j = 0; j < arr1[i].Length; j++)
                {
                    //Console.Write($"{arr1[i, j]} \n");
                    arr[j] = arr1[i][j] + arr2[i][j];
                    //result[i][j] = arr1[i][j] + arr2[i][j];
                }
                result[i] = arr;
            }

            return result;
        }

        static void Main(string[] args)
        {
            int[][] arr1 = new int[][] {
                                        new int[]{ 1, 2, 3 },
                                        new int[] { 3, 2, 1 },
                                        new int[] { 1, 1, 1 }
                                       };
            int[][] arr2 = new int[][] {
                                        new int[]{ 2, 2, 1 },
                                        new int[]{ 3, 2, 3 },
                                        new int[]{ 1, 1, 3 }
                                        };
            Test(arr1, arr2);
            Console.ReadKey();
        }
    }
}
