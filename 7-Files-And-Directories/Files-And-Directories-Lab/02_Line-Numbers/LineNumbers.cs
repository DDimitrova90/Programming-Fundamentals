using System;
using System.IO;

public class LineNumbers
{
    public static void Main()
    {
        string[] text = File.ReadAllLines("Input.txt");

        File.WriteAllText("Output.txt", "");

        for (int i = 0; i < text.Length; i++)
        {
            File.AppendAllText("Output.txt", $"{i + 1}. {text[i]}{Environment.NewLine}");
        }

        //for (int i = 0; i < text.Length; i++)
        //{
        //    text[i] = $"{i + 1}" + ". " + text[i];
        //}

        //File.WriteAllLines("Output.txt", text);
    }
}
