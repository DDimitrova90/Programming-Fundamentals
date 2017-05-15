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

        var keys = numbers.Distinct().OrderBy(x => x);

        foreach (var k in keys)
        {
            var count = numbers.Count(x => x == k);
            Console.WriteLine($"{k} -> {count}");
        }
    }
}

