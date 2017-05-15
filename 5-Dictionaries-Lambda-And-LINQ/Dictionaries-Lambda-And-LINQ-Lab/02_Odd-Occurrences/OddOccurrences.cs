using System;
using System.Collections.Generic;

public class OddOccurrences
{
    public static void Main()
    {
        string[] words = Console.ReadLine().ToLower().Split(' ');

        Dictionary<string, int> counter = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (counter.ContainsKey(word))
            {
                counter[word]++;
            }
            else
            {
                counter[word] = 1;
            }
        }

        List<string> wordsWithOddValues = new List<string>();

        foreach (KeyValuePair<string, int> pair in counter)
        {
            if (pair.Value % 2 != 0)
            {
                wordsWithOddValues.Add(pair.Key);
            }
        }

        Console.WriteLine(string.Join(", ", wordsWithOddValues));
    }
}

