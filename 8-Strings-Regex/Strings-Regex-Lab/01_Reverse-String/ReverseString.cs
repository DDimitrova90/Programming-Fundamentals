using System;

public class ReverseString
{
    public static void Main()
    {
        string str = Console.ReadLine();

        char[] arr = str.ToCharArray();
        Array.Reverse(arr);
        string reversed = new string(arr);

        Console.WriteLine(reversed);

        //Console.WriteLine(string.Join("", str.Reverse()));
    }
}

