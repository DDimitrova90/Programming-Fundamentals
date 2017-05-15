using System;
using System.IO;

public class OddLines
{
    public static void Main()
    {
        string[] file = File.ReadAllLines("Input.txt");

        File.WriteAllText("Output.txt", "");

        for (int i = 0; i < file.Length; i++)
        {
            if (i % 2 != 0)
            {
                File.AppendAllText("Output.txt", file[i] + Environment.NewLine); // or \n
            }
        }

        //File.WriteAllLines("Output.txt", file.Where((line, index) => index % 2 != 0));
    }                                                            // or index % 2 == 1
}

