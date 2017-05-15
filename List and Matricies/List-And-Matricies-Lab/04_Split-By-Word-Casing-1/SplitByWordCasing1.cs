using System;
using System.Collections.Generic;
using System.Linq;

class SplitByWordCasing1
{
    static void Main()
    {
        char[] separators = new char[] 
        { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' };
        List<string> words = Console.ReadLine()
            .Split(separators, StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        List<string> lowerCaseLetters = new List<string>();
        List<string> upperCaseLetters = new List<string>();
        List<string> mixedCaseLetters = new List<string>();

        foreach (var word in words)
        {
            var type = GetWordType(word);

            if (type == WordType.Uppercase)
                upperCaseLetters.Add(word);
            else if (type == WordType.Lowercase)
                lowerCaseLetters.Add(word);
            else 
                mixedCaseLetters.Add(word);
        }

        Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCaseLetters));
        Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCaseLetters));
        Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCaseLetters));
    }

    enum WordType { Uppercase, Mixedcase, Lowercase };

    static WordType GetWordType(string word)
    {
        int lowerLetters = 0;
        int upperLetters = 0;

        foreach (var letter in word)
        {
            if (char.IsUpper(letter))
            {
                upperLetters++;
            }
            else if (char.IsLower(letter))
            {
                lowerLetters++;
            }
        }

        if (lowerLetters == word.Length)
            return WordType.Lowercase;
        if (upperLetters == word.Length)
            return WordType.Uppercase;
        return WordType.Mixedcase;
    }
}

