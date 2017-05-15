using System;
using System.Linq;

class SquaresInMatrix
{
    static void Main()
    {
        int[] parameters = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
        int rows = parameters[0];
        int cols = parameters[1];

        int countSquares = 0;
        char[][] matrix = new char[rows][];

        for (int row = 0; row < rows; row++)
        {
            matrix[row] = Console.ReadLine()
                .Split(' ')
                .Select(char.Parse)
                .ToArray();
        }

        for (int row = 1; row < rows; row++)
        {
            for (int col = 1; col < cols; col++)  
            {
                if ((matrix[row][col] == matrix[row][col - 1]) && 
                    (matrix[row - 1][col] == matrix[row - 1][col - 1]) && 
                    (matrix[row][col - 1] == matrix[row - 1][col]))
                {
                    countSquares++;
                }
            }
        }

        Console.WriteLine(countSquares);
    }
}
