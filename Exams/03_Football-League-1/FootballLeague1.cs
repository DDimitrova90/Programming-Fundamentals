using System;
using System.Collections.Generic;
using System.Linq;

public class FootballLeague1
{
    public static void Main()
    {
        string key = Console.ReadLine();
        string input = Console.ReadLine();

        Dictionary<string, long> scoresResults = new Dictionary<string, long>();
        Dictionary<string, long> goalsResults = new Dictionary<string, long>();

        while (input != "final")
        {
            string[] matchInfo = input.Split(' ');
            string[] goals = matchInfo[matchInfo.Length - 1].Split(':');
            int firstTeamGoals = int.Parse(goals[0]);
            int secondTeamGoals = int.Parse(goals[1]);
            int firstTeamScores = 0;
            int secondTeamScores = 0;

            if (firstTeamGoals > secondTeamGoals)
            {
                firstTeamScores = 3;
            }
            else if (firstTeamGoals < secondTeamGoals)
            {
                secondTeamScores = 3;
            }
            else
            {
                firstTeamScores = 1;
                secondTeamScores = 1;
            }

            int startIndexFirst = matchInfo[0].IndexOf(key) + key.Length;
            int lengthFirst = matchInfo[0]
                .LastIndexOf(key) - matchInfo[0].IndexOf(key) - key.Length;
            char[] teamNFirst = matchInfo[0]
                .Substring(startIndexFirst, lengthFirst)
                .ToCharArray();
            Array.Reverse(teamNFirst);
            string firstTeamName = new string(teamNFirst).ToUpper();

            int startIndexSecond = matchInfo[1].IndexOf(key) + key.Length;
            int lengthSecond = matchInfo[1]
                .LastIndexOf(key) - matchInfo[1].IndexOf(key) - key.Length;
            char[] teamNSecond = matchInfo[1]
                .Substring(startIndexSecond, lengthSecond)
                .ToCharArray();
            Array.Reverse(teamNSecond);
            string secondTeamName = new string(teamNSecond).ToUpper();

            if (!scoresResults.ContainsKey(firstTeamName))
            {
                scoresResults.Add(firstTeamName, 0);
            }

            scoresResults[firstTeamName] += firstTeamScores;

            if (!scoresResults.ContainsKey(secondTeamName))
            {
                scoresResults.Add(secondTeamName, 0);
            }

            scoresResults[secondTeamName] += secondTeamScores;

            if (!goalsResults.ContainsKey(firstTeamName))
            {
                goalsResults.Add(firstTeamName, 0);
            }

            goalsResults[firstTeamName] += firstTeamGoals;

            if (!goalsResults.ContainsKey(secondTeamName))
            {
                goalsResults.Add(secondTeamName, 0);
            }

            goalsResults[secondTeamName] += secondTeamGoals;

            input = Console.ReadLine();
        }

        Console.WriteLine("League standings:");

        int p = 1;
        foreach (var team in scoresResults.OrderByDescending(s => s.Value).ThenBy(n => n.Key))
        {
            Console.WriteLine($"{p}. {team.Key} {team.Value}");
            p++;
        }

        Console.WriteLine("Top 3 scored goals:");

        var topThree = goalsResults
            .OrderByDescending(g => g.Value)
            .ThenBy(n => n.Key)
            .Take(3);

        foreach (var team in topThree)
        {
            Console.WriteLine($"- {team.Key} -> {team.Value}");
        }
    }
}





