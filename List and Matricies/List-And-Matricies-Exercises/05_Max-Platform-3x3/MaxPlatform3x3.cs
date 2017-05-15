using System;
using System.Linq;

class MaxPlatform3x3
{
    static void Main()
    {
        string[] parameters = Console.ReadLine().Split(' ');
        int rows = int.Parse(parameters[0]);
        int cols = int.Parse(parameters[1]);

        long[][] matrix = new long[rows][];
        long sum = 0;
        long maxSum = long.MinValue;
        int endRow = 0;
        int endCol = 0;

        for (int row = 0; row < rows; row++)
        {
            matrix[row] = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();
        }

        for (int row = 2; row < rows; row++)
        {
            for (int col = 2; col < cols; col++)
            {
                sum += matrix[row][col] + matrix[row][col - 1] + matrix[row][col - 2] + 
                    matrix[row - 1][col] + matrix[row - 1][col - 1] + matrix[row - 1][col - 2] + 
                    matrix[row - 2][col] + matrix[row - 2][col - 1] + matrix[row - 2][col - 2];

                if (sum > maxSum)
                {
                    endRow = row;
                    endCol = col;
                    maxSum = sum;
                }

                sum = 0;
            }
        }

        Console.WriteLine(maxSum);

        int curCol = endCol;

        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.Write(matrix[endRow - 2][curCol - 2] + " ");
                curCol++;
            }

            endRow++;
            curCol = endCol;

            Console.WriteLine();
        }
    }
}

