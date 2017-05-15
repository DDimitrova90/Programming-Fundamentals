using System;

public class CountSubstringOccurrences
{
    public static void Main()
    {
        string text = Console.ReadLine().ToLower();
        string substr = Console.ReadLine().ToLower();

        int counter = 0;
        int index = text.IndexOf(substr);

        while (index != -1)
        {
            counter++;
            index = text.IndexOf(substr, index + 1);
        }

        Console.WriteLine(counter);
    }
}

