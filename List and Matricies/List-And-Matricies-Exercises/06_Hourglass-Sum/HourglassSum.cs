using System;
using System.Linq;

class HourglassSum
{
    static void Main()
    {
        long[][] matrix = new long[6][];

        for (int row = 0; row < 6; row++)
        {
            matrix[row] = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();
        }

        long hourGlassSum = 0;
        long maxSum = long.MinValue;

        for (int row = 2; row < 6; row++)
        {
            for (int col = 2; col < 6; col++)
            {
                hourGlassSum += matrix[row][col] + matrix[row][col - 1] + 
                    matrix[row][col - 2] + matrix[row - 1][col - 1] + 
                    matrix[row - 2][col] + matrix[row - 2][col - 1] + 
                    matrix[row - 2][col - 2];

                if (hourGlassSum > maxSum)
                {
                    maxSum = hourGlassSum;
                }

                hourGlassSum = 0;
            }
        }

        Console.WriteLine(maxSum);
    }
}

