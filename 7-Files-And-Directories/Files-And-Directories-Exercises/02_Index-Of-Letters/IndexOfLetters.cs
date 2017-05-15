using System;
using System.IO;

public class IndexOfLetters
{
    public static void Main()
    {
        string word = Console.ReadLine();

        char[] alphabet = new char[26];

        File.WriteAllText("Input.txt", "");
        File.WriteAllText("Input.txt", word);
        File.WriteAllText("Output.txt", "");

        for (int i = 0; i < alphabet.Length; i++)
        {
            alphabet[i] = (char)(97 + i);
        }

        foreach (var letter in word)
        {
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (letter == alphabet[i])
                {
                    string result = $"{letter} -> {i}";
                    Console.WriteLine(result);
                    File.AppendAllText("Output.txt", result + Environment.NewLine);
                }
            }
        }
    }
}

