using System;
using System.Collections.Generic;    // https://judge.softuni.bg/Contests/Practice/Index/217#2
using System.Linq;

public class FootballLeague
{
    public static void Main()
    {
        string key = Console.ReadLine();
        string input = Console.ReadLine();

        SortedDictionary<string, long> matchesResults = 
            new SortedDictionary<string, long>();
        SortedDictionary<string, long> teamsScores = 
            new SortedDictionary<string, long>();

        while (input != "final")
        {
            string[] resultsInfo = input.Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);

            int firstKeyPos = resultsInfo[0].IndexOf(key);
            int firstKeyPos1 = resultsInfo[0].LastIndexOf(key);
            int secondKeyPos = resultsInfo[1].IndexOf(key);
            int secondKeyPos1 = resultsInfo[1].LastIndexOf(key);

            char[] first = resultsInfo[0]
                .Substring(firstKeyPos + key.Length, firstKeyPos1 - firstKeyPos - key.Length)
                .Reverse()
                .ToArray();
            string firstTeam = new string(first).ToUpper();
            char[] second = resultsInfo[1]
                .Substring(secondKeyPos + key.Length, secondKeyPos1 - secondKeyPos - key.Length)
                .Reverse()
                .ToArray();
            string secondTeam = new string(second).ToUpper();

            long firstScores = long.Parse(resultsInfo[2]);
            long secondScores = long.Parse(resultsInfo[3]);
            long scoresFirstTeam = 0;
            long scoresSecondTeam = 0;

            if (firstScores > secondScores)
            {
                scoresFirstTeam = 3;
            }
            else if (firstScores < secondScores)
            {
                scoresSecondTeam = 3;
            }
            else
            {
                scoresFirstTeam = 1;
                scoresSecondTeam = 1;
            }

            if (!matchesResults.ContainsKey(firstTeam))
            {
                matchesResults.Add(firstTeam, 0);
            }

            matchesResults[firstTeam] += scoresFirstTeam;

            if (!matchesResults.ContainsKey(secondTeam))
            {
                matchesResults.Add(secondTeam, 0);
            }

            matchesResults[secondTeam] += scoresSecondTeam;

            if(!teamsScores.ContainsKey(firstTeam))
            {
                teamsScores.Add(firstTeam, 0);
            }

            teamsScores[firstTeam] += firstScores;

            if (!teamsScores.ContainsKey(secondTeam))
            {
                teamsScores.Add(secondTeam, 0);
            }

            teamsScores[secondTeam] += secondScores;

            input = Console.ReadLine();
        }

        long pos = 1;

        Console.WriteLine("League standings:");

        foreach (var team in matchesResults.OrderByDescending(p => p.Value))
        {
            Console.WriteLine($"{pos}. {team.Key} {team.Value}");
            pos++;
        }

        Console.WriteLine("Top 3 scored goals:");

        var ordered = teamsScores.OrderByDescending(p => p.Value).Take(3);

        foreach (var team in ordered)
        {
            Console.WriteLine($"- {team.Key} -> {team.Value}");
        }
    }
}

