using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class RageQuit
{
    public static void Main()
    {
        string input = Console.ReadLine();
        string pattern = @"([a-zA-Z\W\D\s.]+)(\d+)";

        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(input);
        StringBuilder result = new StringBuilder();

        foreach (Match match in matches)
        {
            string currStr = match.Groups[1].ToString().ToUpper();
            int repeats = int.Parse(match.Groups[2].ToString());

            for (int i = 0; i < repeats; i++)
            {
                result.Append(currStr);
            }
        }

        int uniqueElements = result.ToString().Distinct().Count();

        Console.WriteLine("Unique symbols used: {0}", uniqueElements);
        Console.WriteLine(result);
    }
}

