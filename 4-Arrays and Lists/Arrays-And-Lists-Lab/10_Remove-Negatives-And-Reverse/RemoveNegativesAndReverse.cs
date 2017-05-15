using System;
using System.Collections.Generic;
using System.Linq;

public class RemoveNegativesAndReverse
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ')
            .Select(int.Parse)
            .ToList();

        numbers.Reverse();

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] < 0)
            {
                numbers.Remove(numbers[i]);
                i--;
            }
        }

        if (numbers.Count == 0)
        {
            Console.WriteLine("empty");
        }
        else
        {
            Console.WriteLine(string.Join(" ", numbers));
        }  
    }
}

