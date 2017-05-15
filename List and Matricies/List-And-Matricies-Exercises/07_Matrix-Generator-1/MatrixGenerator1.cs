using System;
using System.Linq;

namespace _4_7_Exercize_Matrix_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            // task with jagged arrays
            string[] input = Console.ReadLine().Split(' ').ToArray();
            string a = input[0];
            string b = input[1];
            string c = input[2];

            int rows = Int32.Parse(b); // converts String to int
            int cols = Int32.Parse(c); // converts String to int
            int[][] matrix = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = new int[cols];
                for (int col = 0; col < cols; col++)
                {
                    matrix[row][col] = 0;
                }
            }

            if (a == "A")
            {
                GetTypeA(rows, cols, matrix);
            }

            if (a == "B")
            {
                GetTypeB(rows, cols, matrix);
            }

            if (a == "C")
            {
                GetTypeC(rows, cols, matrix);
            }

            if (a == "D")
            {
                GetTypeD(rows, cols, matrix);
            }
        }

        private static void GetTypeA(int rows, int cols, int[][] matrix)
        {
            int d = 1;

            for (int col = 0; col < cols; col++)
            {
                for (int row = 0; row < rows; row++)
                {
                    matrix[row][col] = d;
                    d++;
                }
            }

            for (int row = 0; row < rows; row++)
                Console.WriteLine(string.Join(" ", matrix[row]));
        }

        private static void GetTypeB(int rows, int cols, int[][] matrix)
        {
            int d = 1;

            for (int col = 0; col < cols; col++)
            {
                if (col == 0)
                {
                    for (int row = 0; row < rows; row++)
                    {
                        matrix[row][col] = d;
                        d++;
                    }

                    continue;
                }

                if (col % 2 != 0)
                {
                    for (int row = rows - 1; row >= 0; row--)
                    {
                        matrix[row][col] = d;
                        d++;
                    }
                }

                if (col % 2 == 0)
                {
                    for (int row = 0; row < rows; row++)
                    {
                        matrix[row][col] = d;
                        d++;
                    }
                }
                /// Print the matrix
            }

            for (int row = 0; row < rows; row++)
                Console.WriteLine(string.Join(" ", matrix[row]));
        }

        static void GetTypeC(int rows, int cols, int[][] matrix)
        {
            // the first down left part of the matrix(jagged array)
            int number = 1;

            for (int row = rows - 1; row >= 0; row--)
            {
                int startRow = row;

                for (int col = 0; col < rows - startRow; col++)
                {
                    if (col > cols - 1) { break; }
                    matrix[startRow + col][col] = number;
                    number++;
                }
            }

            // the second up right part of the matrix (jagged array)
            for (int col = 1; col < cols; col++)
            {
                int startCol = col;

                for (int row = 0; row < cols - startCol; row++)
                {
                    if (row > rows - 1) { break; }
                    matrix[row][startCol + row] = number;
                    number++;
                }
            }

            // Print matrix (jagged array)
            for (int row = 0; row < rows; row++)
                Console.WriteLine(string.Join(" ", matrix[row]));
        }

        static void GetTypeD(int rows, int cols, int[][] matrix)
        {
            int number = 1;
            int indexRow = 0;
            int indexCol = 0;

            while (number <= rows * cols)
            {
                matrix[indexRow][indexCol] = number;
                number++;

                bool canGoDown = (indexRow + 1) < rows && matrix[indexRow + 1][indexCol] == 0 &&
                    !((indexCol - 1) >= 0 && matrix[indexRow][indexCol - 1] == 0);
                if (canGoDown) { indexRow++; continue; }
                bool canGoRight = (indexCol + 1) < cols && matrix[indexRow][indexCol + 1] == 0;
                if (canGoRight) { indexCol++; continue; }
                bool canGoUp = (indexRow - 1) >= 0 && matrix[indexRow - 1][indexCol] == 0;
                if (canGoUp) { indexRow--; continue; }
                bool canGoLeft = (indexCol - 1) >= 0 && matrix[indexRow][indexCol - 1] == 0;
                if (canGoLeft) { indexCol--; continue; }
            }

            // Print matrix (jagged array)
            for (int row = 0; row < rows; row++)
                Console.WriteLine(string.Join(" ", matrix[row]));
        }
    }
}
