using System;
using System.Linq;

public class ShortWordsSorted
{
    public static void Main()
    {
        string text = Console.ReadLine().ToLower();
        char[] separators = new char[] 
        { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };
        string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        words = words.Where(x => x.Length < 5).OrderBy(x => x).Distinct().ToArray();

        Console.WriteLine(string.Join(", ", words));
    }
}

