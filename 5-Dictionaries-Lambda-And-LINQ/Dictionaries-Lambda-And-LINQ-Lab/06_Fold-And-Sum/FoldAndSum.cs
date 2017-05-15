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

        int[] leftRow1 = numbers.Take(k).Reverse().ToArray();
        int[] rightRow1 = numbers.Reverse().Take(k).ToArray();
        int[] row1 = leftRow1.Concat(rightRow1).ToArray();
        int[] row2 = numbers.Skip(k).Take(2 * k).ToArray();
        int[] sumArr = row1.Select((x, index) => x + row2[index]).ToArray();

        Console.WriteLine(string.Join(" ", sumArr));
    }
}

