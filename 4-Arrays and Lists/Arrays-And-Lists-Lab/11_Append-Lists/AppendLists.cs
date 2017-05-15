using System;
using System.Collections.Generic;
using System.Linq;

public class AppendLists
{
    public static void Main()
    {
        List<string> items = Console.ReadLine().Split('|').ToList();

        items.Reverse();
        List<string> result = new List<string>();

        foreach (var item in items)
        {
            List<string> numbers = item.Split(' ').ToList();

            foreach (var num in numbers)
            {
                if (num != "")
                {
                    result.Add(num);
                }
            }
        }

        Console.WriteLine(string.Join(" ", result));
    }
}

