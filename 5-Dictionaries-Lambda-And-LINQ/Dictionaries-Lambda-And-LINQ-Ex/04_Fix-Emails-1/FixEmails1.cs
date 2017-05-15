using System;
using System.Collections.Generic;
using System.Linq;

public class FixEmails1
{
    public static void Main()
    {
        Dictionary<string, string> usersEmails = new Dictionary<string, string>();
        string[] domains = { ".us", ".uk" };

        string userName = Console.ReadLine();

        while (!userName.Equals("stop"))
        {
            string userEmail = Console.ReadLine();
            usersEmails.Add(userName, userEmail);
            userName = Console.ReadLine();
        }

        RemoveEmailsByDomain(usersEmails, domains);
        PrintEmails(usersEmails);
    }

    private static void PrintEmails(Dictionary<string, string> usersEmails)
    {
        foreach (var userEntry in usersEmails)
        {
            Console.WriteLine($"{userEntry.Key} -> {userEntry.Value}");
        }
    }

    private static void RemoveEmailsByDomain(Dictionary<string, string> usersEmails, string[] domains)
    {
        foreach (var domain in domains)
        {
            var filteredEmails = usersEmails.Where(x => x.Value.EndsWith(domain)).ToList();

            foreach (var userEntry in filteredEmails)
            {
                usersEmails.Remove(userEntry.Key); 
            }
        }
    }
}

