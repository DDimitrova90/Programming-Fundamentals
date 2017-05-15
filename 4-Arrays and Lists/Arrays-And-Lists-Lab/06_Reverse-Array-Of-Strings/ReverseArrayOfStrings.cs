using System;

public class ReverseArrayOfStrings
{
    public static void Main()
    {
        string[] str = Console.ReadLine().Split(' ');

        for (int i = 0; i < str.Length / 2; i++)
        {
            string currStr = str[i];
            str[i] = str[str.Length - 1 - i];
            str[str.Length - i - 1] = currStr;
        }

        Console.WriteLine(string.Join(" ", str));
    }
}

