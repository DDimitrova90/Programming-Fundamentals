using System;
using System.Collections.Generic;
using System.Linq;

class MaxSequenceOfEqualElements
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        List<int> result = new List<int>();

        int start = 0;
        int len = 1;
        int maxLen = 1;
        int bestStart = 0;

        for (int i = 1; i < numbers.Count; i++)
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

            if (len > maxLen)
            {
                maxLen = len;
                bestStart = start;
            }
        }

        for (int i = bestStart; i < bestStart + maxLen; i++)
        {
            result.Add(numbers[i]);
        }

        Console.WriteLine(string.Join(" ", result));
    }
}
