using System;
using System.Collections.Generic;

public class AMinerTask
{
    public static void Main()
    {
        List<string> sequence = new List<string>();
        string input = Console.ReadLine();

        while (input != "stop")
        {
            sequence.Add(input);

            input = Console.ReadLine();
        }

        Dictionary<string, int> resources = new Dictionary<string, int>();

        for (int i = 0; i < sequence.Count; i++)
        {
            if (i % 2 == 0)
            {
                if (resources.ContainsKey(sequence[i]))
                {
                    resources[sequence[i]] += int.Parse(sequence[i + 1]);
                }
                else
                {
                    resources[sequence[i]] = int.Parse(sequence[i + 1]);
                }     
            }
        }

        foreach (KeyValuePair<string, int> pair in resources)
        {
            Console.WriteLine($"{pair.Key} -> {pair.Value}");
        }
    }
}

