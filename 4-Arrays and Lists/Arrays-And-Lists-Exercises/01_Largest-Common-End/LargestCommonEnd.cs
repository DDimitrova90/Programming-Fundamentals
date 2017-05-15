using System;
using System.Linq;

public class LargestCommonEnd
{
    public static void Main()
    {
        string[] arr1 = Console.ReadLine().Split(' ').ToArray();
        string[] arr2 = Console.ReadLine().Split(' ').ToArray();

        int shorterLen = Math.Min(arr1.Length, arr2.Length);
        int leftCounter = 0;
        int rightCounter = 0;

        for (int i = 0; i < shorterLen; i++)
        {
            if (arr1[i] == arr2[i])
            {
                leftCounter++;
            }         
        }

        int k = 0;
        for (int i = shorterLen; i > 0; i--)
        {
            if (arr1[arr1.Length - 1 - k] == arr2[arr2.Length - 1 - k])
            {
                rightCounter++;
                k++;
            }
        }

        Console.WriteLine(Math.Max(leftCounter, rightCounter));
    }
}

