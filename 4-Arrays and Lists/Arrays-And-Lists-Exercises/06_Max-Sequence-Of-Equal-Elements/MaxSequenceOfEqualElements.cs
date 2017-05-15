using System;
using System.Linq;

public class MaxSequenceOfEqualElements
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        int[] longestSeq = GetLongestSequence(numbers);

        Console.WriteLine(string.Join(" ", longestSeq));
    }

    static int[] GetLongestSequence(int[] numbers)
    {
        int len = 1;
        int start = 0;
        int maxLen = 1;
        int bestStart = 0;

        for (int i = 1; i < numbers.Length; i++)
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

        int[] lonestSeq = new int[maxLen];

        for (int i = 0; i < maxLen; i++)
        {
            lonestSeq[i] = numbers[bestStart + i];
        }

        return lonestSeq;
    }
}

