using System;
using System.Linq;

public class MaxSequenceOfIncreasingElements
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        int[] maxSeq = GetMaxSeqOfIncreasingElements(numbers);

        Console.WriteLine(string.Join(" ", maxSeq));
    }

    static int[] GetMaxSeqOfIncreasingElements(int[] numbers)
    {
        int start = 0;
        int bestStart = 0;
        int len = 1;
        int maxLen = 1;

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i - 1] < numbers[i])
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

        int[] maxSeq = new int[maxLen];

        for (int i = 0; i < maxLen; i++)
        {
            maxSeq[i] = numbers[bestStart + i]; 
        }

        return maxSeq;
    }
}

