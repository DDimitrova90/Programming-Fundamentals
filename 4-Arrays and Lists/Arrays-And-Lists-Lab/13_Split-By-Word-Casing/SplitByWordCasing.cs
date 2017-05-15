using System;
using System.Collections.Generic;
using System.Linq;

public class SplitByWordCasing
{
    public static void Main()
    {
        char[] separator = { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' };
        List<string> text = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();

        List<string> upperCaseWords = new List<string>();
        List<string> lowerCaseWords = new List<string>();
        List<string> mixedCaseWords = new List<string>();

        foreach (var word in text)
        {
            int lowerCaseLetters = 0;
            int upperCaseLetters = 0;

            foreach (var letter in word)
            {
                if (char.IsLower(letter))
                {
                    lowerCaseLetters++;
                }
                else if (char.IsUpper(letter))
                {
                    upperCaseLetters++;
                }
            }

            if (lowerCaseLetters == word.Length)
            {
                lowerCaseWords.Add(word);
            }
            else if (upperCaseLetters == word.Length)
            {
                upperCaseWords.Add(word);
            }
            else
            {
                mixedCaseWords.Add(word);
            }
        }

        Console.WriteLine("Lower-case: " + string.Join(", ", lowerCaseWords));
        Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCaseWords));
        Console.WriteLine("Upper-case: " + string.Join(", ", upperCaseWords));
    }
}

