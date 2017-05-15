using System;
using System.IO;
using System.Linq;

public class MergeFiles
{
    public static void Main()
    {
        string[] firstText = File.ReadAllText("FileOne.txt")
            .Split(new char[] { ' ', '\n', '\r' }, 
            StringSplitOptions.RemoveEmptyEntries);
        string[] secondText = File.ReadAllText("FileTwo.txt")
            .Split(new char[] { ' ', '\n', '\r' },
            StringSplitOptions.RemoveEmptyEntries);

        string[] allText = firstText
            .Concat(secondText)
            .OrderBy(x => x)
            .ToArray();

        File.WriteAllLines("Output.txt", allText);       
    }
}


