using System;
using System.Linq;

class CompareCharArrays3
{
    static void Main()
    {
        char[] firstArray = Console.ReadLine()
            .Split()
            .Select(char.Parse)
            .ToArray();
        char[] secondArray = Console.ReadLine()
            .Split()
            .Select(char.Parse)
            .ToArray();

        if (string.Join("", firstArray).CompareTo(string.Join("", secondArray)) > 0)
        {
            Console.WriteLine(secondArray);
            Console.WriteLine(firstArray);
        }
        else
        {
            Console.WriteLine(firstArray);
            Console.WriteLine(secondArray);
        }
    }
}

