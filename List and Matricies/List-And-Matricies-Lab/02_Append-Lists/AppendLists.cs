using System;
using System.Collections.Generic;
using System.Linq;

class AppendLists
{
    static void Main()
    {
        List<string> items = Console.ReadLine().Split('|').ToList();
        items.Reverse();

        List<string> result = new List<string>();

        foreach (var item in items)
        {
            List<string> numbers = item.Split(' ').ToList();

            foreach (var number in numbers)
            {
                if (number != "")
                {
                    result.Add(number);
                }
            }
        }

        Console.WriteLine(string.Join(" ", result));
    }
}

