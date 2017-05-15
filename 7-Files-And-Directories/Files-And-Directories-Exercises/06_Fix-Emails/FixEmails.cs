using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class FixEmails
{
    public static void Main()
    {
        string name = Console.ReadLine();

        File.WriteAllText("Input.txt", "");
        File.WriteAllText("Output.txt", "");
        File.AppendAllText("Input.txt", name + "\r\n");

        Dictionary<string, string> emails = new Dictionary<string, string>();
        string[] domains = new string[] { ".us", ".uk" }; 

        while (name != "stop")
        {
            string email = Console.ReadLine();

            File.AppendAllText("Input.txt", email + "\r\n");

            emails.Add(name, email);

            name = Console.ReadLine();

            File.AppendAllText("Input.txt", name + "\r\n");
        }
 
        foreach (var domain in domains)
        {
            var filteredEmails = emails.Where(x => x.Value.EndsWith(domain)).ToList();

            foreach (var pair in filteredEmails)
            {
                emails.Remove(pair.Key);
            }
        }

        foreach (var pair in emails)
        {
            File.AppendAllText("Output.txt", $"{pair.Key} -> {pair.Value}\r\n");
            Console.WriteLine($"{pair.Key} -> {pair.Value}");
        }
    }
}

