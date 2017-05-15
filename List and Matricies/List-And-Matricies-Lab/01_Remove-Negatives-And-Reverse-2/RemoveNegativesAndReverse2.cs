using System;
using System.Collections.Generic;
using System.Linq;

class RemoveNegativesAndReverse2
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] < 0)
            {
                numbers.Remove(numbers[i]); // or numbers.RemoveAt(i);
                i--;
            }
        }

        numbers.Reverse();

        if (numbers.Count > 0)
        {
            Console.WriteLine(string.Join(" ", numbers));
        }
        else
        {
            Console.WriteLine("empty");
        }
    }
}

