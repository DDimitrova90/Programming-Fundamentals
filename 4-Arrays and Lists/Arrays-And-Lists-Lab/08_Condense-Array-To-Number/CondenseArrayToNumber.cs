using System;
using System.Linq;

public class CondenseArrayToNumber
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        while (numbers.Length > 1)
        {
            int[] condensedNums = new int[numbers.Length - 1];

            for (int i = 0; i < condensedNums.Length; i++)
            {
                condensedNums[i] = numbers[i] + numbers[i + 1];
            }

            numbers = condensedNums;
        }

        Console.WriteLine(numbers[0]);
    }
}

