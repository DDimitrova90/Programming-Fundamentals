using System;

public class TextFilter
{
    public static void Main()
    {
        string[] banList = Console.ReadLine()
            .Split(new char[] { ',', ' ' }, 
            StringSplitOptions.RemoveEmptyEntries);
        string text = Console.ReadLine();

        foreach (var word in banList)
        {
            text = text.Replace(word, new string('*', word.Length));
        }

        Console.WriteLine(text);
    }
}

