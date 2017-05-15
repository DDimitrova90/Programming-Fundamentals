using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class WordCount
{
    public static void Main()
    {
        string[] words = File.ReadAllText("words.txt").Split(' ');

        string[] text = File.ReadAllText("text.txt")
            .ToLower()
            .Split(new char[] { '-', ' ', ',', '.', '?', '!', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> wordsCount = new Dictionary<string, int>();

        foreach (var word in words)
        {
            wordsCount.Add(word, 0);
        }

        foreach (var word in text)
        {
            if (wordsCount.ContainsKey(word))
            {
                wordsCount[word]++;
            }
        }

        File.WriteAllText("Output.txt", "");

        var ordered = wordsCount.OrderByDescending(c => c.Value);

        foreach (var pair in ordered)
        {
            File.AppendAllText("Output.txt", $"{pair.Key} - {pair.Value}\r\n");
        }
    }
}

