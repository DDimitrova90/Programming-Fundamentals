using System;

public class UnicodeCharacters
{
    public static void Main()
    {
        string str = Console.ReadLine();

        for (int i = 0; i < str.Length; i++)
        {
            Console.Write("\\u" + ((int)str[i]).ToString("x4"));
        }
    }
}

