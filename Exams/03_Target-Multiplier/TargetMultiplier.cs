using System;
using System.Linq;        // https://judge.softuni.bg/Contests/Practice/Index/215#2

public class TargetMultiplier
{
    public static void Main()
    {
        string[] matrixDimensions = Console.ReadLine().Split(' ');
        int rows = int.Parse(matrixDimensions[0]);
        int cols = int.Parse(matrixDimensions[1]);
        long[][] matrix = new long[rows][];

        for (int row = 0; row < rows; row++)
        {
            matrix[row] = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();
        }

        string[] targetedDimensions = Console.ReadLine().Split(' ');
        int targetedRow = int.Parse(targetedDimensions[0]);
        int targetedCol = int.Parse(targetedDimensions[1]);

        long neighboursSum = 0;
        long targetCell = matrix[targetedRow][targetedCol];

        for (int currRow = targetedRow - 1; currRow <= targetedRow + 1; currRow++)
        {
            for (int currCol = targetedCol - 1; currCol <= targetedCol + 1; currCol++)
            {
                if (currRow != targetedRow || currCol != targetedCol)
                {
                    neighboursSum += matrix[currRow][currCol];
                    matrix[currRow][currCol] *= targetCell;
                }
            }
        }

        matrix[targetedRow][targetedCol] *= neighboursSum;

        foreach (var row in matrix)
        {
            Console.WriteLine(string.Join(" ", row));
        }
    }
}

