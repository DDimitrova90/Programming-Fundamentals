using System;
using System.Collections.Generic;
using System.Linq;

class SquareNumbers
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        List<int> squareNumbers = new List<int>();

        foreach (var number in numbers)
        {                                                    // or
            if (Math.Sqrt(number) == (int)Math.Sqrt(number)) // int sqrt = Math.Sqrt(number);
            {                                                // if (sqrt * sqrt == number) ili
                squareNumbers.Add(number);                   // Math.Sqrt(number) % 1.0 == 0
            }
        }

        squareNumbers.Sort((a, b) => b.CompareTo(a));

        Console.WriteLine(string.Join(" ", squareNumbers));
    }
}

