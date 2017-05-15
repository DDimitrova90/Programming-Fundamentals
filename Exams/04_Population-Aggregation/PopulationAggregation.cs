using System;
using System.Collections.Generic;     // https://judge.softuni.bg/Contests/Practice/Index/215#3
using System.Linq;

public class PopulationAggregation
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();

        Dictionary<string, Dictionary<string, long>> countriesPop = 
            new Dictionary<string, Dictionary<string, long>>();
        Dictionary<string, int> townsInCountry = new Dictionary<string, int>();

        while (input != "stop")
        {
            string[] citiesInfo = input.Split('\\');
            long populationCount = long.Parse(citiesInfo[citiesInfo.Length - 1]);
            char[] first = citiesInfo[0]
                .Where(x => x != '@' && x != '#' && x != '$' && x != '&' && !char.IsNumber(x))
                .ToArray();
            char[] second = citiesInfo[1]
                .Where(x => x != '@' && x != '#' && x != '$' && x != '&' && !char.IsNumber(x))
                .ToArray();
            string firstStr = new string(first);
            string secondStr = new string(second);

            if (char.IsUpper(firstStr.ElementAt(0)))
            {
                if (!countriesPop.ContainsKey(firstStr))
                {
                    countriesPop[firstStr] = new Dictionary<string, long>();
                }

                if (!townsInCountry.ContainsKey(firstStr))
                {
                    townsInCountry[firstStr] = 0;
                }

                townsInCountry[firstStr]++;
                countriesPop[firstStr][secondStr] = populationCount;
            }
            else if (char.IsUpper(secondStr.ElementAt(0)))
            {
                if (!countriesPop.ContainsKey(secondStr))
                {
                    countriesPop[secondStr] = new Dictionary<string, long>();
                }

                if (!townsInCountry.ContainsKey(secondStr))
                {
                    townsInCountry[secondStr] = 0;
                }

                townsInCountry[secondStr]++;
                countriesPop[secondStr][firstStr] = populationCount;
            }

            input = Console.ReadLine();
        }

        foreach (var country in townsInCountry.OrderBy(c => c.Key))
        {
            Console.WriteLine($"{country.Key} -> {country.Value}");
        }

        Dictionary<string, long> citiesList = new Dictionary<string, long>();

        foreach (var country in countriesPop)
        {
            foreach (var city in country.Value)
            {
                if (!citiesList.ContainsKey(city.Key))
                {
                    citiesList[city.Key] = 0;
                }

                citiesList[city.Key] += city.Value;
            }
        }

        foreach (var city in citiesList.OrderByDescending(p => p.Value).Take(3))
        {
            Console.WriteLine($"{city.Key} -> {city.Value}");
        }
    }
}

