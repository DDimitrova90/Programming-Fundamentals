using System;
using System.Linq;   

class MostFrequentNumber1
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        int[] distinctNumbers = numbers
            .Distinct()
            .OrderBy(x => x)
            .ToArray(); 
        int[] repeats = new int[distinctNumbers.Length];

        for (int i = 0; i < distinctNumbers.Length; i++)
        {
            repeats[i] = numbers.Count(number => number == distinctNumbers[i]); 
        }

        Console.WriteLine(distinctNumbers[repeats.ToList().IndexOf(repeats.Max())]);
    }
}

