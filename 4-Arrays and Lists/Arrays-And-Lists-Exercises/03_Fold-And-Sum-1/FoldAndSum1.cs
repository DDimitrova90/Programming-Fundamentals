using System;
using System.Linq;

public class FoldAndSum1
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        int k = numbers.Length / 4;

        int[] firstKElements = new int[k];
        int[] lastKElements = new int[k];

        for (int i = 0; i < k; i++)
        {
            firstKElements[i] = numbers[i];
            lastKElements[i] = numbers[(3 * k) + i];
        }

        Array.Reverse(firstKElements);
        Array.Reverse(lastKElements);

        int[] finalArray = new int[2 * k];

        for (int i = 0; i < k; i++)
        {
            finalArray[i] = firstKElements[i] + numbers[k + i];
            finalArray[k + i] = lastKElements[i] + numbers[(2 * k) + i];
        }

        Console.WriteLine(string.Join(" ", finalArray));
    }
}

