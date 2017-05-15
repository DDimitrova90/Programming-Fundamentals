using System;
using System.Linq;

public class SumArrays
{
    public static void Main()
    {
        int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] result = new int[Math.Max(arr1.Length, arr2.Length)];

        for (int i = 0; i < result.Length; i++)
        {
            result[i] = arr1[i % arr1.Length] + arr2[i % arr2.Length];
        }

        Console.WriteLine(string.Join(" ", result));
    }
}

