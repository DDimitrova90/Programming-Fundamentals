using System;
using System.Collections.Generic;
using System.Linq;

public class CountNumbers
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();
        numbers.Sort();

        PrintNumberOccurrences(numbers);
    }

    static void PrintNumberOccurrences(List<int> numbers)
    {
        int count = 1;

        for (int i = 0; i < numbers.Count; i++)
        {
            if (i == numbers.Count - 1 || numbers[i] != numbers[i + 1])
            {
                Console.WriteLine($"{numbers[i]} -> {count}");  
                count = 1;
            }
            else
            {
                count++;
            }
        }
    }
}

