using System;
using System.Collections.Generic;
using System.Linq;

public class Palindromes
{
    public static void Main()
    {
        string[] words = Console.ReadLine()
            .Split(new char[] { ' ', ',', '.', '?', '!' }, 
            StringSplitOptions.RemoveEmptyEntries);

        List<string> palindromes = new List<string>();

        for (int i = 0; i < words.Length; i++)
        {
            char[] arr = words[i].ToCharArray();
            Array.Reverse(arr);
            string reversedWord = new string(arr);

            if (words[i].Equals(reversedWord) && !palindromes.Contains(words[i]))
            {
                palindromes.Add(words[i]);
            }
        }

        Console.WriteLine(string.Join(", ", palindromes.OrderBy(x => x)));
    }
}

