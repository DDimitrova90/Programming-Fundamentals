using System;
using System.Collections.Generic;
using System.Linq;

class CountNumbers
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        Dictionary<int, int> counts = new Dictionary<int, int>();

        foreach (int number in numbers)
        {
            if (counts.ContainsKey(number))
            {
                counts[number]++;
            }
            else
            {
                counts[number] = 1;
            }            
        }

        foreach (var i in counts.Keys.OrderBy(x => x))
        {
            Console.WriteLine($"{i} -> {counts[i]}");
        }
    }
}

