using System;
using System.Collections.Generic;
using System.Linq;

class AppendLists1
{
    static void Main()
    {
        string[] lists = Console.ReadLine().Split('|');
        List<string> result = new List<string>();

        for (int i = lists.Length - 1; i >= 0; i--)
        {
            List<string> list = lists[i].Split(' ').ToList();

            foreach (var num in list)
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

