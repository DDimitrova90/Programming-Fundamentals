using System;
using System.Collections.Generic;
using System.Linq;

public class Largest3Numbers
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        //numbers = numbers.OrderByDescending(x => x).Take(3).ToList();
        numbers = numbers.OrderBy(x => -x).Take(3).ToList();

        Console.WriteLine(string.Join(" ", numbers));
    }
}

