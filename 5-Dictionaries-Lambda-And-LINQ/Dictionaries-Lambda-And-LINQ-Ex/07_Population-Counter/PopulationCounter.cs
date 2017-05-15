using System;
using System.Collections.Generic;
using System.Linq;

public class PopulationCounter
{
    public static void Main()
    {
        string input = Console.ReadLine();

        Dictionary<string, Dictionary<string, long>> countriesData = 
            new Dictionary<string, Dictionary<string, long>>();

        while (input != "report")
        {
            string[] rawData = input.Split('|');
            string country = rawData[1];
            string city = rawData[0];
            long population = long.Parse(rawData[2]);

            if(!countriesData.ContainsKey(country))
            {
                countriesData[country] = new Dictionary<string, long>();
            }

            if(!countriesData[country].ContainsKey(city))
            {
                countriesData[country][city] = population;
            }
            else
            {
                countriesData[country][city] += population;
            }

            input = Console.ReadLine();
        }

        Dictionary<string, long> countryTotalPop = new Dictionary<string, long>();

        foreach (KeyValuePair<string, Dictionary<string, long>> state in countriesData)
        {
            long totalPopulation = 0;

            foreach (KeyValuePair<string, long> pair in state.Value)
            {
                totalPopulation += pair.Value;
            }

            countryTotalPop[state.Key] = totalPopulation;
        }

        foreach (KeyValuePair<string, long> state in countryTotalPop.OrderByDescending(x => x.Value))
        {
            Console.WriteLine($"{state.Key} (total population: {state.Value})");

            foreach (KeyValuePair<string, Dictionary<string, long>> c in countriesData)
            {
                if (c.Key == state.Key)
                {
                    foreach (KeyValuePair<string, long> pair in c.Value.OrderByDescending(x => x.Value))
                    {
                        Console.WriteLine($"=>{pair.Key}: {pair.Value}");
                    }
                }
            }
        }
    }
}

