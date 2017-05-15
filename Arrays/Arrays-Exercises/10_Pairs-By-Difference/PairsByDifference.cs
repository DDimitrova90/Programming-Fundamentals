using System;
using System.Linq;

class PairsByDifference
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        int diff = int.Parse(Console.ReadLine());

        FindPairsByDifferance(numbers, diff);
    }

    static void FindPairsByDifferance(int[] numbers, int diff)
    {
        int countPairs = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; j < numbers.Length; j++)
            {
                int pairDiff = numbers[i] - numbers[j];

                if (pairDiff == diff && i != j)
                {
                    countPairs++;
                }
            }
        }

        Console.WriteLine(countPairs);
    }
}

