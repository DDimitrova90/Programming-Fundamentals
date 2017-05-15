using System;
using System.Linq;

class MaxSequenceOfEqualElements
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        int len = 1;
        int start = 0;
        int bestStart = 0;
        int bestLen = 0;

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] == numbers[i - 1])
            {
                len++;
            }
            else
            {
                len = 1;
                start = i;
            }

            if (len > bestLen)
            {
                bestLen = len;
                bestStart = start;
            }
        }

        int[] result = new int[bestLen];
        for (int i = 0; i < bestLen; i++)
        {
            result[i] = numbers[bestStart];
            bestStart++;
        }

        Console.WriteLine(string.Join(" ", result));
    }
}

