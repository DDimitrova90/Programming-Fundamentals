using System;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        string text = Console.ReadLine();
        string pattern = @"\b(?<!\S)(([a-z0-9\-\.]+@[a-z0-9\-]+\.[a-z]+([\.a-z]+)?))\b";

        //(?<!\S) - checks for symbol that is not white space before the word
        //(([a-z0-9\-\.]+@[a-z0-9\-]+\.[a-z]+([\.a-z]+)?)) 
        //([\.a-z]+)? - optional group, if there is more than one domain

        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(text);

        foreach (Match match in matches)
        {
            Console.WriteLine(match);
        }
    }
}
