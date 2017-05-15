using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        string input = Console.ReadLine();

        List<string> data = new List<string>();
        Dictionary<string, string> emails = new Dictionary<string, string>();

        while (input != "stop")
        {
            data.Add(input);

            input = Console.ReadLine();
        }

        for (int i = 0; i < data.Count; i++)
        {
            if (i % 2 == 0)
            {
                string emailDomain = data[i + 1].Substring(data[i + 1].Length - 2);

                if (!emailDomain.Equals("us") && !emailDomain.Equals("uk"))
                {
                    emails[data[i]] = data[i + 1];
                }
            }
        }

        foreach (KeyValuePair<string, string> pair in emails)
        {
            Console.WriteLine($"{pair.Key} -> {pair.Value}");
        }
    }
}

