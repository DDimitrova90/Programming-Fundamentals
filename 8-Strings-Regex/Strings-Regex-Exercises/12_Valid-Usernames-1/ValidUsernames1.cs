using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Ex
{
    public static void Main()
    {
        string[] text = Console.ReadLine()
            .Split(new char[] { ' ', '\\', '/', '(', ')' }, 
            StringSplitOptions.RemoveEmptyEntries);
        string pattern = @"\b[a-zA-z][\w]{2,24}\b";
        Regex regex = new Regex(pattern);
        List<string> valid = new List<string>();

        foreach (var username in text)
        {
            if (regex.IsMatch(username))
            {
                valid.Add(username);
            }
        }

        int len = 0;
        int maxLen = int.MinValue;
        string firstUsername = "";
        string secondUsername = "";

        for (int i = 0; i < valid.Count - 1; i++)
        {
            len = valid[i].Length + valid[i + 1].Length;

            if (len > maxLen)
            {
                maxLen = len;
                firstUsername = valid[i];
                secondUsername = valid[i + 1];
            }
        }

        Console.WriteLine(firstUsername);
        Console.WriteLine(secondUsername);
    }
}


