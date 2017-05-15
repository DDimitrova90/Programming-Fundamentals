using System;
using System.Collections.Generic;

public class Phonebook
{
    public static void Main()
    {
        string[] command = Console.ReadLine().Split(' ');
        string action = command[0];
        Dictionary<string, string> phonebook = new Dictionary<string, string>();

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

            command = Console.ReadLine().Split(' ');
            action = command[0];
        }
    }

    private static void PrintEntry(string[] command, Dictionary<string, string> phonebook)
    {
        bool containsKey = phonebook.ContainsKey(command[1]);

        if (containsKey)
        {
            Console.WriteLine("{0} -> {1}", command[1], phonebook[command[1]]);
        }
        else
        {
            Console.WriteLine($"Contact {command[1]} does not exist.");
        }
    }

    private static void AddEntry(string[] command, Dictionary<string, string> phonebook)
    {
        phonebook[command[1]] = command[2];
    }
}
