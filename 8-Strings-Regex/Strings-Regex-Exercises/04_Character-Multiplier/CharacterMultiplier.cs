using System;

public class CharacterMultiplier
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        string str1 = input[0];
        string str2 = input[1];

        long sum = GetCharacterCodesSum(str1, str2);

        Console.WriteLine(sum);
    }

    public static long GetCharacterCodesSum(string str1, string str2)
    {
        int shorter = Math.Min(str1.Length, str2.Length);
        long sum = 0;

        for (int i = 0; i < shorter; i++)
        {
            sum += str1[i] * str2[i];
        }

        string longerStr = "";

        if (str1.Length > str2.Length)
        {
            longerStr = str1;
        }
        else if (str1.Length < str2.Length)
        {
            longerStr = str2;
        }

        for (int i = shorter; i <= longerStr.Length - 1; i++)
        {
            sum += longerStr[i];
        }

        return sum;
    }
}

