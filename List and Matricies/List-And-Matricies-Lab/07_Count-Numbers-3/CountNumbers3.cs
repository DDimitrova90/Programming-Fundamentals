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

        numbers.Sort();

        int start = 0;
        int len = 1;

        for (int i = 0; i < numbers.Count; i++)
        {
            if (i == numbers.Count - 1 || numbers[i] != numbers[i + 1])
            {
                //Current sequence ends. New sequence starts.
                Console.WriteLine(numbers[start] + " -> " + len);
                start = i + 1;
                len = 1;
            }
            else
            {
                len++;
            }
        }
    }
}

