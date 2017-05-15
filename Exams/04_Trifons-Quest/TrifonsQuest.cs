using System;
using System.Linq;   // https://judge.softuni.bg/Contests/Practice/Index/217#3

public class TrifonsQuest
{
    public static void Main()
    {
        long healthPoints = long.Parse(Console.ReadLine());
        int[] dimensions = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
        int rows = dimensions[0];
        int cols = dimensions[1];
        int turns = 0;

        char[][] matrix = new char[rows][];

        for (int row = 0; row < rows; row++)
        {
            string input = Console.ReadLine();
            matrix[row] = new char[cols];

            for (int col = 0; col < input.Length; col++)
            {
                matrix[row][col] = input[col];
            }
        }

        for (int col = 0; col < cols; col++)
        {
            int p = 0;
            for (int row = 0; row < rows; row++)
            {
                if (col % 2 != 0)
                {
                    p++;
                    row = rows - p;
                }

                switch (matrix[row][col])
                {
                    case 'F':
                        healthPoints -= (turns / 2);
                        turns++;
                        break;
                    case 'H':
                        healthPoints += (turns / 3);
                        turns++;
                        break;
                    case 'T':
                        turns += 3;
                        break;
                    case 'E':
                        turns++;
                        break;
                }

                if (healthPoints <= 0)
                {
                    Console.WriteLine($"Died at: [{row}, {col}]");
                    return;
                }

                if (col % 2 != 0)
                {
                    if (row == 0 && col == cols - 1)
                    {
                        break;
                    }
                }
                else
                {
                    if (row == rows - 1 && col == cols - 1)
                    {
                        break;
                    }
                }

                if (col % 2 != 0)
                {
                    row--;
                    if (row < 0)
                    {
                        row = rows - 1;
                    }
                }
            }
        }

        Console.WriteLine("Quest completed!");
        Console.WriteLine($"Health: {healthPoints}");
        Console.WriteLine($"Turns: {turns}");
    }
}

