using System;
using System.Collections.Generic;
using System.Linq;

class SplitByWordCasing
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
            int lowerCaseChars = 0;
            int upperCaseChars = 0;

            foreach (char letter in word)
            {
                if (char.IsLower(letter))
                {
                    lowerCaseChars++;
                }
                else if (char.IsUpper(letter))
                {
                    upperCaseChars++;
                }
            }

            if (lowerCaseChars == word.Length)
            {
                lowerCaseLetters.Add(word);
            }
            else if (upperCaseChars == word.Length)
            {
                upperCaseLetters.Add(word);
            }
            else
            {
                mixedCaseLetters.Add(word);
            }
        }

        Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCaseLetters));
        Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCaseLetters));
        Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCaseLetters));
    }
}

