using System;
using System.Collections.Generic;
using System.Linq;

public class PhonebookUpgrade
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
                phonebook[command[1]] = command[2];
            }
            else if (action == "S")
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
            else if (action == "ListAll")
            {
                phonebook = phonebook.OrderBy(n => n.Key).ToDictionary(n => n.Key, p => p.Value);

                //List<KeyValuePair<string, string>> orderedPhonebook = phonebook.OrderBy(x => x.Key).ToList();

                foreach (string name in phonebook.Keys) //(var pair in orderedPhonebook) i t.n.
                {
                    Console.WriteLine($"{name} -> {phonebook[name]}");
                }
            }

            command = Console.ReadLine().Split(' ');
            action = command[0];
        }
    }
}

