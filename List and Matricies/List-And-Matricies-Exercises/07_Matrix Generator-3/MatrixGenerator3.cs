using System;

namespace MatrixGenerator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] dims = Console.ReadLine().Split(' ');
            long[,] matrix = new long[long.Parse(dims[1]), long.Parse(dims[2])];

            switch (dims[0])
            {
                case "A":
                    printMatrixA(matrix);
                    break;
                case "B":
                    printMatrixB(matrix);
                    break;
                case "C":
                    printMatrixC(matrix);
                    break;
                case "D":
                    printMatrixD(matrix);
                    break;
                default:
                    break;
            }
        }

        static void printMatrixA(long[,] matrix)
        {
            for (long i = 0; i < matrix.GetLength(1); i++)
            {
                for (long j = 0; j < matrix.GetLength(0); j++)
                {
                    matrix[j, i] = matrix.GetLength(0) * i + j + 1;
                }
            }

            for (long i = 0; i < matrix.GetLength(0); i++)
            {
                for (long j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j].ToString() + " ");
                }

                Console.WriteLine();
            }
        }

        static void printMatrixB(long[,] matrix)
        {
            for (long i = 0; i < matrix.GetLength(1); i++)
            {
                for (long j = 0; j < matrix.GetLength(0); j++)
                {
                    if (i % 2 == 0)
                    {
                        matrix[j, i] = matrix.GetLength(0) * i + j + 1;
                    }
                    else
                    {
                        matrix[matrix.GetLength(0) - j - 1, i] = matrix.GetLength(0) * i + j + 1;
                    }
                }
            }

            for (long i = 0; i < matrix.GetLength(0); i++)
            {
                for (long j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j].ToString() + " ");
                }

                Console.WriteLine();
            }
        }

        static void printMatrixC(long[,] matrix)
        {
            long value = 1;

            for (long i = 0; i < matrix.GetLength(0); i++)
            {
                for (long k = 0; k < Math.Min(i + 1, matrix.GetLength(1)); k++)
                {
                    matrix[matrix.GetLength(0) - 1 - i + k, k] = value;
                    value++;
                }
            }

            for (long i = 0; i < matrix.GetLength(1) - 1; i++)
            {
                for (long k = i + 1; k < matrix.GetLength(1); k++)
                {
                    matrix[k - i - 1, k] = value;
                    value++;
                }
            }

            for (long i = 0; i < matrix.GetLength(0); i++)
            {
                for (long j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j].ToString() + " ");
                }

                Console.WriteLine();
            }
        }

        static void printMatrixD(long[,] matrix)
        {
            long value = 1;
            long it = 0;

            while (value <= matrix.Length)
            {
                for (long i = it; i < matrix.GetLength(0) - it; i++)
                {
                    matrix[i, it] = value;
                    value++;
                }

                if (value > matrix.Length)
                {
                    break;
                }

                for (long i = it + 1; i < matrix.GetLength(1) - it; i++)
                {
                    matrix[matrix.GetLength(0) - 1 - it, i] = value;
                    value++;
                }

                if (value > matrix.Length)
                {
                    break;
                }

                for (long i = matrix.GetLength(0) - 2 - it; i >= it; i--)
                {
                    matrix[i, matrix.GetLength(1) - 1 - it] = value;
                    value++;
                }

                if (value > matrix.Length)
                {
                    break;
                }

                for (long i = matrix.GetLength(1) - 2 - it; i >= it + 1; i--)
                {
                    matrix[it, i] = value;
                    value++;
                }

                it++;
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j].ToString() + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
