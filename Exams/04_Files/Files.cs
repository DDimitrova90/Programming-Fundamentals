using System;
using System.Collections.Generic;    // https://judge.softuni.bg/Contests/Practice/Index/285#3
using System.Linq;

public class Files
{
    public static void Main()
    {
        List<File> files = ReadFiles();
        Dictionary<string, long> filesByExtension = GetFilesByExtension(files);
        PrintFiles(filesByExtension);
    }

    static void PrintFiles(Dictionary<string, long> filesByExtension)
    {
        if (filesByExtension.Count == 0)
        {
            Console.WriteLine("No");
        }
        else
        {
            var orderedFiles = filesByExtension
                .OrderByDescending(s => s.Value)
                .ThenBy(n => n.Key);

            foreach (var file in orderedFiles)
            {
                Console.WriteLine($"{file.Key} - {file.Value} KB");
            }
        } 
    }

    static Dictionary<string, long> GetFilesByExtension(List<File> files)
    {
        Dictionary<string, long> filesByExtension = new Dictionary<string, long>();
        string[] query = Console.ReadLine().Split(' ');
        string extension = query[0];
        string wantedRoot = query[2];

        foreach (var file in files)
        {
            if (file.Root.Equals(wantedRoot) && file.Name.EndsWith(extension))
            {
                filesByExtension[file.Name] = file.Size;   
            }
        }

        return filesByExtension;
    }

    static List<File> ReadFiles()
    {
        int fileNumber = int.Parse(Console.ReadLine());
        List<File> files = new List<File>();

        for (int i = 0; i < fileNumber; i++)
        {
            File file = ReadFile();
            files.Add(file);
        }

        return files;
    }

    static File ReadFile()
    {
        string[] fileInfo = Console.ReadLine()
            .Split(new char[] { '\\', ';' }, StringSplitOptions.RemoveEmptyEntries);

        File file = new File();
        string root = fileInfo[0];
        long size = long.Parse(fileInfo[fileInfo.Length - 1]);
        string name = fileInfo[fileInfo.Length - 2];
        List<string> folders = new List<string>();

        for (int i = 1; i < fileInfo.Length - 2; i++)
        {
            folders.Add(fileInfo[i]);
        }

        file.Root = root;
        file.Size = size;
        file.Name = name;
        file.Folders = folders;

        return file;
    }
}

public class File
{
    public string Root { get; set; }
    public List<string> Folders { get; set; }
    public string Name { get; set; }
    public long Size { get; set; }
}

