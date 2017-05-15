using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Ex
{
    public static void Main()
    {
        string input = Console.ReadLine();
        string replacement = @"((%20|\+)+)";
        string pattern = @"([^&=\?]*)=([^=&\?]*)";

        while (input != "END")
        {
            Dictionary<string, List<string>> query = new Dictionary<string, List<string>>();
            input = Regex.Replace(input, replacement, " ");
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                string key = match.Groups[1].ToString().Trim();
                string value = match.Groups[2].ToString().Trim();

                if (!query.ContainsKey(key))
                {
                    query[key] = new List<string>();
                }

                query[key].Add(value);
            }

            foreach (var pair in query)
            {
                Console.Write(pair.Key + "=[" + string.Join(", ", pair.Value) + "]");
            }

            Console.WriteLine();

            input = Console.ReadLine();
        }
    }
}


