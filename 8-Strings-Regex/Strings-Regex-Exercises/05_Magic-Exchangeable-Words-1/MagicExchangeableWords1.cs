using System;
using System.Collections.Generic;

public class MagicExchangeableWords1  
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        string str1 = input[0];
        string str2 = input[1];

        bool areExchangeable = AreExchangeable(str1, str2);

        Console.WriteLine(areExchangeable ? "true" : "false");
    }

    public static bool AreExchangeable(string str1, string str2)
    {
        string shorterStr = GetShorterStr(str1, str2);
        string longerStr = GetLongerStr(str1, str2);

        Dictionary<char, char> chars = new Dictionary<char, char>();

        for (int i = 0; i < shorterStr.Length; i++)
        {
            if (!chars.ContainsKey(longerStr[i]))
            {
                chars[longerStr[i]] = shorterStr[i];
            }
            else if (chars[longerStr[i]] != shorterStr[i])
            {
                return false;
            } 
        }

        for (int i = shorterStr.Length; i < longerStr.Length; i++)
        {
            if (!chars.ContainsKey(longerStr[i]))
            {
                return false;
            }
        }

        return true;
    }

    static string GetLongerStr(string str1, string str2)
    {
        if (str1.Length >= str2.Length)
        {
            return str1;
        }
        else 
        {
            return str2;
        }
    }

    static string GetShorterStr(string str1, string str2)
    {
        if (str1.Length <= str2.Length)
        {
            return str1;
        }
        else
        {
            return str2;
        }
    }
}

