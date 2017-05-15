using System;
using System.Linq;

public class RotateAndSum
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
        int rotations = int.Parse(Console.ReadLine());

        int[] result = GetSumOfRotatedArrays(numbers, rotations);
        
        Console.WriteLine(string.Join(" ", result));
    }

    static int[] GetSumOfRotatedArrays(int[] numbers, int rotations)
    {
        int[] sum = new int[numbers.Length];

        while (rotations > 0)
        {
            int[] rotatedNums = new int[numbers.Length];

            for (int i = 1; i < numbers.Length; i++)
            {
                rotatedNums[i] += numbers[i - 1];
            }

            rotatedNums[0] += numbers[numbers.Length - 1];
            numbers = rotatedNums;
            rotations--;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum[i] += rotatedNums[i];
            }
        }

        return sum;
    }
}

