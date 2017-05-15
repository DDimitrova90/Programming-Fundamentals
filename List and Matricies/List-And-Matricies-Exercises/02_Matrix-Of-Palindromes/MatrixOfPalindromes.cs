using System;
using System.Linq;

class MatrixOfPalindromes
{
    static void Main()
    {
        int[] parameters = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
        int rows = parameters[0];
        int cols = parameters[1];

        string[][] matrix = new string[rows][];

        for (int row = 0; row < rows; row++)
        {
            matrix[row] = new string[cols];

            for (int col = 0; col < cols; col++)
            {
                char firstLastLetter = (char)(97 + row);
                char middleLetter = (char)(97 + row + col);
                matrix[row][col] = "" + firstLastLetter + middleLetter + firstLastLetter;

                Console.Write(matrix[row][col] + " ");
            }

            Console.WriteLine();
        }
    }
}

