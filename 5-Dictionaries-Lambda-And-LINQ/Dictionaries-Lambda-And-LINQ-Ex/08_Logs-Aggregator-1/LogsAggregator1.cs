using System;
using System.Collections.Generic;
using System.Linq;

public class LogsAggregator1
{
    public static void Main()
    {
        SortedDictionary<string, SortedDictionary<string, int>> userLogs = 
            new SortedDictionary<string, SortedDictionary<string, int>>();

        int entryCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < entryCount; i++)
        {
            string entry = Console.ReadLine();
            string[] entryArgs = entry.Split(new char[] { ' ' }, 
                StringSplitOptions.RemoveEmptyEntries);

            string ip = entryArgs[0];
            string userName = entryArgs[1];
            int duration = int.Parse(entryArgs[2]);

            InsertUserName(userLogs, userName);
            InsertIpAndDuration(userLogs, userName, ip, duration);
        }

        PrintUserLogs(userLogs);
    }

    private static void PrintUserLogs(SortedDictionary<string, SortedDictionary<string, int>> userLogs)
    {
        foreach (var userEntry in userLogs)
        {
            string userName = userEntry.Key;
            int totalDuration = userEntry.Value.Values.Sum();
            List<string> userIps = userEntry.Value.Keys.ToList();

            Console.WriteLine("{0}: {1} [{2}]", 
                userName, totalDuration, string.Join(", ", userIps));
        }
    }

    private static void InsertIpAndDuration(SortedDictionary<string, SortedDictionary<string, int>> userLogs, string userName, string ip, int duration)
    {
        if (!userLogs[userName].ContainsKey(ip))
        {
            userLogs[userName].Add(ip, 0);
        }

        userLogs[userName][ip] += duration;
    }

    private static void InsertUserName(SortedDictionary<string, SortedDictionary<string, int>> userLogs, string userName)
    {
        if (!userLogs.ContainsKey(userName))
        {
            userLogs.Add(userName, new SortedDictionary<string, int>());
        }
    }
}

