using System;

public class IndexOfLetters
{
    public static void Main()
    {
        string word = Console.ReadLine();

        char[] alphabet = new char[26];
        char currChar = 'a';

        for (int i = 0; i < alphabet.Length; i++)
        {
            alphabet[i] = currChar;
            currChar++;
        }

        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (word[i] == alphabet[j])
                {
                    Console.WriteLine($"{word[i]} -> {j}");
                }
            }
        }
    }
}

