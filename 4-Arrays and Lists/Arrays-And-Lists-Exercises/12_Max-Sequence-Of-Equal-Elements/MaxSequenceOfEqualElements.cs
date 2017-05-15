using System;
using System.Collections.Generic;
using System.Linq;

public class MaxSequenceOfEqualElements
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        List<int> maxSeq = GetMaxSeqOfEqualElements(numbers);

        Console.WriteLine(string.Join(" ", maxSeq));
    }

    static List<int> GetMaxSeqOfEqualElements(List<int> numbers)
    {
        List<int> maxSeq = new List<int>();
        int len = 1;
        int maxLen = 1;
        int start = 0;
        int bestStart = 0;

        for (int i = 1; i < numbers.Count; i++)
        {
            if (numbers[i - 1] == numbers[i])
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
            maxSeq.Add(numbers[i]);
        }

        return maxSeq;
    }
}

