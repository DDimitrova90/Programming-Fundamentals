using System;
using System.Linq;

class Tour
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        int[][] matrix = new int[size][];

        for (int row = 0; row < size; row++)
        {
            matrix[row] = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
        }

        int[] route = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        long sum = matrix[0][route[0]];

        for (int i = 0; i < route.Length - 1; i++) //4 towns, 3 travels
        {
            sum += matrix[route[i]][route[i + 1]];
        }

        Console.WriteLine(sum);
    }
}

