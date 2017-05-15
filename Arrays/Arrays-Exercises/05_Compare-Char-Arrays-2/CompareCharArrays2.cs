using System;
using System.Linq;

class CompareCharArrays2
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

        string[] array = { new string(arr1), new string(arr2) };

        Array.Sort(array);

        Console.WriteLine(string.Join("\n", array));
    }
}

