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
                return items.GetUpperBound(1) + 1;
            }
        }

        public Matrix(int[,] items)
        {
            this.items = items;
        }

        public override string ToString()
        {
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                   str += $"{items[i, j]} \t";
                }
                str += "\n";
            }

            return str;
        }
        
        public static Matrix operator + (Matrix mtrx1, Matrix mtrx2)
        {
            int[,] result = new int[mtrx1.rows, mtrx1.cols];

            for (int i = 0; i < mtrx1.rows; i++)
            {
                for (int j = 0; j < mtrx1.cols; j++)
                {
                    result[i, j] = mtrx1.items[i, j] + mtrx2.items[i, j];
                }
            }

            return new Matrix(result);
        }

        public static Matrix operator *(Matrix mtrx1, Matrix mtrx2)
        {
            int[,] result = new int[mtrx1.rows, mtrx2.cols];

            for (int i = 0; i < mtrx1.rows; i++)
            {
                for (int j = 0; j < mtrx2.cols; j++)
                {
                    for (int k = 0; k < mtrx1.cols; k++)
                    {
                        result[i, j] += mtrx1.items[i, k] * mtrx2.items[k, j];
                    }
                }
            }
            return new Matrix(result);
        }

        public static bool operator ==(Matrix mtrx1, Matrix mtrx2)
        {
            bool result = true;

            for (int i = 0; i < mtrx1.rows; i++)
            {
                for (int j = 0; j < mtrx2.cols; j++)
                {
                    for (int k = 0; k < mtrx1.cols; k++)
                    {
                        result = mtrx1.items[i, k] == mtrx2.items[k, j];
                    }
                }
            }
            return result;
        }

        public static bool operator !=(Matrix mtrx1, Matrix mtrx2)
        {
            bool result = true;

            for (int i = 0; i < mtrx1.rows; i++)
            {
                for (int j = 0; j < mtrx2.cols; j++)
                {
                    for (int k = 0; k < mtrx1.cols; k++)
                    {
                        result = mtrx1.items[i, k] != mtrx2.items[k, j];
                    }
                }
            }
            return result;
        }

        public static Matrix Transpose(Matrix mtrx)
        {
            int[,] result = new int[mtrx.cols, mtrx.rows];

            for (int i = 0; i < mtrx.rows; i++)
            {
                for (int j = 0; j < mtrx.cols; j++)
                {
                    result[j, i] = mtrx.items[i, j];
                }
            }

            return new Matrix(result);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = { { 1, 1 }, { 1, 1 } };
            int[,] arr2 = { { 1, 1 }, { 1, 2 } };
            int[,] arr3 = { { 1, 1, 1 }, { 2, 2, 2 } };

            Matrix mtrx1 = new Matrix(arr1);
            Matrix mtrx2 = new Matrix(arr2);
            Matrix mtrx3 = new Matrix(arr3);

            Console.WriteLine($"Исходная матрица A\n{mtrx1}");
            Console.WriteLine($"Исходная матрица B\n{mtrx2}");
            Console.WriteLine($"Исходная матрица C\n{mtrx3}");

            Matrix mtrxAdd = mtrx1 + mtrx2;
            Console.WriteLine($"Сложение A + B\n{mtrxAdd}");

            Matrix mtrxMulti = mtrx1 * mtrx2;
            Console.WriteLine($"Умножение A * B\n{mtrxMulti}");

            Console.WriteLine($"Сравнение A == A\n{mtrx1 == mtrx1}");
            Console.WriteLine($"Сравнение A == B\n{mtrx1 == mtrx2}");
            Console.WriteLine($"Сравнение A != A\n{mtrx1 != mtrx1}");
            Console.WriteLine($"Сравнение A != B\n{mtrx1 != mtrx2}");

            Console.WriteLine();
            Console.WriteLine($"Транспонирование C\n{Matrix.Transpose(mtrx3)}");

            Console.ReadKey();
        }
    }
}
