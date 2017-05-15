using System;
using System.Linq;

class MostFrequentNumber
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int result = FindsMostFrequentNumber(numbers);
        Console.WriteLine(result);
    }

    static int FindsMostFrequentNumber(int[] numbers)
    {
        int repeats = 1;
        int maxRepeats = 1;
        int result = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[i] == numbers[j] && j != i)
                {
                    repeats++;
                }
                else
                {
                    repeats = 1;
                }

                if (repeats > maxRepeats)
                {
                    maxRepeats = repeats;
                    result = numbers[i];
                }
            }
        }

        if (maxRepeats == 1)
        {
            result = numbers[0];
        }

        return result;
    }
}

