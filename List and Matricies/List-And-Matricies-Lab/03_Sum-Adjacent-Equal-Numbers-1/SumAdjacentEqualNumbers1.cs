using System;
using System.Collections.Generic;
using System.Linq;

class SumAdjacentEqualNumbers1
{
    static void Main()
    {
        List<decimal> numbers = Console.ReadLine()
            .Split(' ')
            .Select(decimal.Parse)
            .ToList();

        for (int i = 1; i < numbers.Count; i++)
        {
            if (numbers[i - 1] == numbers[i])
            {
                numbers[i - 1] += numbers[i];
                numbers.RemoveAt(i);
                i = i - 2;  //or just i = 0;
                if (i < 0) { i = 0; }
            }
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}

