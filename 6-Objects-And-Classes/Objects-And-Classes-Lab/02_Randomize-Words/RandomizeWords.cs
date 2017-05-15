using System;

public class RandomizeWords
{
    public static void Main()
    {
        string[] text = Console.ReadLine().Split(' ');

        Random rnd = new Random();

        for (int pos1 = 0; pos1 < text.Length; pos1++)
        {           
            int rndPos = rnd.Next(0, text.Length);
            string tempPos = text[pos1];
            text[pos1] = text[rndPos];
            text[rndPos] = tempPos;
        }

        Console.WriteLine(string.Join("\n", text));
    }
}

