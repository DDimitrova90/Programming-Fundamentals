﻿using System;
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

        int[] counts = new int[1001];

        foreach (int number in numbers)
        {
            counts[number]++;
        }

        for (int i = 0; i < counts.Length; i++)
        {
            if (counts[i] > 0)
            {
                Console.WriteLine($"{i} -> {counts[i]}");
            }
        }     
    }
}

