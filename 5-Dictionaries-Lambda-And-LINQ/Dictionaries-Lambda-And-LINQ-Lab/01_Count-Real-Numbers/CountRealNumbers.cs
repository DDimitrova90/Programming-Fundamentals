using System;
using System.Collections.Generic;
using System.Linq;

public class CountRealNumbers
{
    public static void Main()
    {
        List<double> numbers = Console.ReadLine()
            .Split(' ')
            .Select(double.Parse)
            .ToList();

        SortedDictionary<double, int> sortedNums = new SortedDictionary<double, int>();

        foreach (var number in numbers)
        {
            if (sortedNums.ContainsKey(number))
            {
                sortedNums[number]++;
            }
            else
            {
                sortedNums[number] = 1;
            }
        }

        foreach (KeyValuePair<double, int> pair in sortedNums)
        {
            Console.WriteLine($"{pair.Key} -> {pair.Value}");
        }

        //foreach (var number in sortedNums.Keys)
        //{
        //    Console.WriteLine($"{number} -> {sortedNums[number]}");
        //}
    }
}

