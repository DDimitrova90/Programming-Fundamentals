using System;
using System.Linq;

public class FoldAndSum
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        int k = numbers.Length / 4;
        int[] firstRow = new int[2 * k];
        int[] secondRow = new int[2 * k];
        int[] sum = new int[2 * k];

        int j = 0;
        for (int i = k - 1; i >= 0; i--)
        {
            firstRow[j] = numbers[i];
            j++;
        }

        j = 0;
        for (int i = numbers.Length - 1; i > numbers.Length - 1 - k; i--)
        {
            firstRow[k + j] = numbers[i];
            j++;
        }

        j = 0;
        for (int i = k; i < 3 * k; i++)
        {
            secondRow[j] = numbers[i];
            j++;
        }

        for (int i = 0; i < sum.Length; i++)
        {
            sum[i] = firstRow[i] + secondRow[i];
        }

        Console.WriteLine(string.Join(" ", sum));
    }
}

