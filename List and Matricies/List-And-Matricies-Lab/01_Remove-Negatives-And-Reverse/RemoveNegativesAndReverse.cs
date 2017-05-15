using System;
using System.Collections.Generic;
using System.Linq;

class RemoveNegativesAndReverse
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        List<int> positiveNums = new List<int>();

        foreach (var number in numbers)
        {
            if (number >= 0)
            {
                positiveNums.Add(number);
            }
        }

        positiveNums.Reverse();

        if (positiveNums.Count() > 0)
        {
            Console.WriteLine(string.Join(" ", positiveNums));
        }
        else
        {
            Console.WriteLine("empty");
        }
    }
}

