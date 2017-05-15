using System;
using System.Linq;

class FoldAndSum
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        //int k = numbers.Length / 4;

        int[] firstRow = new int[numbers.Length / 2];  //numbers.Length / 2 = 2 * k
        int[] secondRow = new int[numbers.Length / 2];
        int[] sumArray = new int[numbers.Length / 2];

        for (int i = 0; i < firstRow.Length / 2; i++)  //firstRow.Length / 2 = k
        {
            firstRow[i] = numbers[(numbers.Length / 4) - 1 - i]; // numbers.Length / 4 = k i t.n.
        }

        int j = 0;

        for (int i = firstRow.Length / 2; i < firstRow.Length; i++)
        {
            firstRow[i] = numbers[numbers.Length - 1 - j];
            j++;
        }

        for (int i = 0; i < secondRow.Length; i++)
        {
            secondRow[i] = numbers[numbers.Length / 4 + i];
        }

        for (int i = 0; i < sumArray.Length; i++)
        {
            sumArray[i] = firstRow[i] + secondRow[i];
        }

        Console.WriteLine(string.Join(" ", sumArray));
    }
}

