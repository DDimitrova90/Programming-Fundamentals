using System;
using System.Linq;

public class EqualSums
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        bool isSumsEqual = false;

        for (int i = 0; i < numbers.Length; i++)
        {
            int leftSum = 0;
            int rightSum = 0;

            for (int j = 0; j < i; j++)
            {
                leftSum += numbers[j];
            }

            for (int k = i + 1; k < numbers.Length; k++)
            {
                rightSum += numbers[k];
            }

            if (rightSum == leftSum)
            {
                Console.WriteLine(i);
                isSumsEqual = true;
            }
        }

        if (!isSumsEqual)
        {
            Console.WriteLine("no");
        }
    }
}

