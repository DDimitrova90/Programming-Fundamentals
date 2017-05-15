using System;
using System.Collections.Generic;

public class PhonebookUpgrade1
{
    public static void Main()
    {
        string[] command = Console.ReadLine().Split(' ');
        string action = command[0];
        SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

        while (action != "END")
        {
            if (action == "A")
            {
                AddEntry(command, phonebook);
            }
            else if (action == "S")
            {
                PrintEntry(command, phonebook);
            }
            else if (action == "ListAll")
            {
                PrintAllEntries(phonebook);
            }

            command = Console.ReadLine().Split(' ');
            action = command[0];
        }
    }

    private static void PrintAllEntries(SortedDictionary<string, string> phonebook)
    {
        foreach (KeyValuePair<string, string> pair in phonebook)
        {
            Console.WriteLine($"{pair.Key} -> {pair.Value}");
        }
    }

    private static void PrintEntry(string[] command, SortedDictionary<string, string> phonebook)
    {
        bool containsKey = phonebook.ContainsKey(command[1]);

        if (containsKey)
        {
            Console.WriteLine($"{command[1]} -> {phonebook[command[1]]}");
        }
        else
        {
            Console.WriteLine($"Contact {command[1]} does not exist.");
        }
    }

    private static void AddEntry(string[] command, SortedDictionary<string, string> phonebook)
    {
        phonebook[command[1]] = command[2];
    }
}

