using System;
using System.Linq;

class DiagonalDifference
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[][] matrix = new int[n][];

        int primaryDiagonalSum = 0;
        int secondaryDiagonalSum = 0;

        for (int row = 0; row < n; row++)
        {
            matrix[row] = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
        }

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (row == col)
                {
                    primaryDiagonalSum += matrix[row][col];
                }

                if (col == n - 1 - row)
                {
                    secondaryDiagonalSum += matrix[row][col];
                }
            }
        }

        int difference = Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);

        Console.WriteLine(difference);
    }
}

