using System;
using System.Linq;

class CompareCharArrays
{
    static void Main()
    {
        char[] arr1 = Console.ReadLine()
            .Split()
            .Select(arr => char.Parse(arr))
            .ToArray();
        char[] arr2 = Console.ReadLine()
            .Split()
            .Select(arr => char.Parse(arr))
            .ToArray();

        int shorterArr = Math.Min(arr1.Length, arr2.Length);

        for (int i = 0; i < shorterArr; i++)
        {
            if (arr1[i] == arr2[i])
            {
                continue;
            }
            else
            {
                if (arr1[i] < arr2[i])
                {
                    Console.WriteLine(arr1);   //without .Join when we have array from chars
                    Console.WriteLine(arr2);
                }
                else
                {
                    Console.WriteLine(arr2);
                    Console.WriteLine(arr1);
                }

                return;
            }
        }

        if (arr1.Length < arr2.Length)
        {
            Console.WriteLine(arr1);
            Console.WriteLine(arr2);
        }
        else
        {
            Console.WriteLine(arr2);
            Console.WriteLine(arr1);
        }
    }
}

