using System;
using System.Collections.Generic;
using System.Linq;

public class CountRealNumbers1
{
    public static void Main()
    {
        List<double> numbers = Console.ReadLine()
            .Split(' ')
            .Select(double.Parse)
            .ToList();

        SortedDictionary<double, int> sortedNums = new SortedDictionary<double, int>();

        for (int i = 0; i < numbers.Count; i++)
        {
            if (sortedNums.ContainsKey(numbers[i]))
            {
                sortedNums[numbers[i]]++;
            }
            else
            {
                sortedNums[numbers[i]] = 1;
            }
        }

        //foreach (KeyValuePair<double, int> pair in sortedNums)
        //{
        //    Console.WriteLine($"{pair.Key} -> {pair.Value}");
        //}

        foreach (var number in sortedNums.Keys)
        {
            Console.WriteLine($"{number} -> {sortedNums[number]}");
        }
    }
}

