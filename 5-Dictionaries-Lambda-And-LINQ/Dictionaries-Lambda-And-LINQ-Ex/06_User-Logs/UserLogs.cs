using System;
using System.Collections.Generic;
using System.Linq;

public class UserLogs
{
    public static void Main()
    {
        string input = Console.ReadLine();

        SortedDictionary<string, Dictionary<string, int>> usersLogs = 
            new SortedDictionary<string, Dictionary<string, int>>();

        while (input != "end")
        {
            string[] logsData = input.Split(new char[] { ' ', '=' }, 
                StringSplitOptions.RemoveEmptyEntries);
            string ip = logsData[1];
            string username = logsData[5];
            int counter = 1;

            if (!usersLogs.ContainsKey(username))
            {
                usersLogs.Add(username, new Dictionary<string, int>());
            }
            if (!usersLogs[username].ContainsKey(ip))
            {
                usersLogs[username].Add(ip, counter);
            }
            else
            {
                usersLogs[username][ip]++;
            }

            input = Console.ReadLine();
        }

        foreach (var user in usersLogs)
        {
            Console.WriteLine($"{user.Key}: ");

            foreach (var log in user.Value)
            {
                if (log.Key != user.Value.Keys.Last())
                {
                    Console.Write($"{log.Key} => {log.Value}, ");
                }
                else
                {
                    Console.WriteLine($"{log.Key} => {log.Value}.");
                }
            }
        }
    }
}

