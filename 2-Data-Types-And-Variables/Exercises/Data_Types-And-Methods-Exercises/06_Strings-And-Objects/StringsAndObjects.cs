using System;

class StringsAndObjects
{
    static void Main()
    {
        string word1 = "Hello";
        string word2 = "World";
        object combination = word1 + " " + word2;
        string result = (string)combination;

        Console.WriteLine(result);
    }
}

