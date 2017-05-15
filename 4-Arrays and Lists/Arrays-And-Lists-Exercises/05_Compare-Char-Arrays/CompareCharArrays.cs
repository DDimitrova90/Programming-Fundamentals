using System;
using System.Linq;

public class CompareCharArrays
{
    public static void Main()
    {
        char[] firstArr = Console.ReadLine()
            .Split(' ')
            .Select(char.Parse)
            .ToArray();
        char[] secondArr = Console.ReadLine()
            .Split(' ')
            .Select(char.Parse)
            .ToArray();

        string[] str = { new string(firstArr), new string(secondArr) };

        Console.WriteLine(string.Join("\n", str.OrderBy(x => x)));
    }
}

