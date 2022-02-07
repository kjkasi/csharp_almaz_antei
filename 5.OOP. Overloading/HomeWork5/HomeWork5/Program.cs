using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Matrix
    {
        private int[,] items;
        public int rows
        {
            get
            {
                return items.GetUpperBound(0) + 1;
            }
        }
        public int cols
        {
            get
            {
                return items.Length / rows;
            }
        }
        public Matrix(int[,] items)
        {
            this.items = items;
        }
        public void Show()
        {
            //int rows = items.GetUpperBound(0) + 1;
            //int cols = items.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{items[i,j]} \t");
                }
                Console.WriteLine();
            }
        }
        public static Matrix operator + (Matrix mtrx1, Matrix mtrx2)
        {
            int[,] result = new int[mtrx1.rows, mtrx1.cols];

            for (int i = 0; i < mtrx1.Length; i++)
            {
                int[] arr = new int[mtrx1[i].Length];
                for (int j = 0; j < mtrx1[i].Length; j++)
                {
                    arr[j] = arr1[i][j] + arr2[i][j];
                }
                result[i] = arr;
            }

            return result;
            return
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = { { 1, 1, 1 }, { 1, 1, 1 } };
            int[,] arr2 = { { 1, 1, 1 }, { 1, 1, 2 } };
            Matrix mtrx1 = new Matrix(arr1);
            Matrix mtrx2 = new Matrix(arr2);
            mtrx1.Show();
            mtrx2.Show();
            Console.ReadKey();
        }
    }
}
