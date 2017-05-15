using System;
using System.Linq;

class SumArrays
{
    static void Main()
    {
        int[] arr1 = Console.ReadLine()
            .Split(' ')
            .Select(arr => int.Parse(arr))
            .ToArray();
        int[] arr2 = Console.ReadLine()
            .Split(' ')
            .Select(arr => int.Parse(arr))
            .ToArray();

        int largerLength = Math.Max(arr1.Length, arr2.Length);

        for (int i = 0; i < largerLength; i++)
        {
            int firstValue = arr1[i % arr1.Length];
            int secondValue = arr2[i % arr2.Length];

            Console.Write("{0} ", firstValue + secondValue);
        }
    }
}

