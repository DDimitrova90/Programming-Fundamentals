using System;
using System.IO;

public class FolderSize
{
    public static void Main()
    {
        string[] files = Directory.GetFiles("TestFolder");
        double totalSize = 0;

        foreach (string file in files)
        {
            FileInfo fileInfo = new FileInfo(file);
            totalSize += fileInfo.Length;
        }

        totalSize = totalSize / 1024 / 1024;

        File.WriteAllText("Output.txt", totalSize.ToString());
    }
}

