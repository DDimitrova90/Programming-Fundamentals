using System;
using System.Linq;

public class PairsByDifference
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
        int difference = int.Parse(Console.ReadLine());

        int pairsNum = CountPairsWithEqualDiff(numbers, difference);

        Console.WriteLine(pairsNum);
    }

    static int CountPairsWithEqualDiff(int[] numbers, int difference)
    {
        int counter = 0;

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                int currDiff = Math.Abs(numbers[i] - numbers[j]);

                if (currDiff == difference)
                {
                    counter++;
                }
            }
        }

        return counter;
    }
}

