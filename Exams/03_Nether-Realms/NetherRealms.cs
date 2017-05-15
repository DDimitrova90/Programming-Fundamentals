using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class NetherRealms
{
    public static void Main()
    {
        string[] names = Console.ReadLine()
            .Split(new char[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        string patternHealth = @"[^0-9\*\/\+-\.\s\,]";
        string patternDamage = @"[\+\-]?[0-9]+(\.?[0-9]+|[0-9]*)";  //(-?\d*\.?\d+) 
        Regex rgxHealth = new Regex(patternHealth);
        Regex rgxDamage = new Regex(patternDamage);
        List<Demon> demons = new List<Demon>();
        
        foreach (string name in names)
        {
            long totalHealth = 0;
            decimal totalDamage = 0;
            MatchCollection matchesHealth = rgxHealth.Matches(name);
            MatchCollection matchesDamage = rgxDamage.Matches(name);
            Demon demon = new Demon();
            demon.Name = name;
            
            foreach (Match match in matchesHealth)
            {
                char currElement = char.Parse(match.ToString());
                totalHealth += currElement;
                demon.Health = totalHealth;
            }

            foreach (Match match in matchesDamage)
            {
                decimal number = decimal.Parse(match.ToString());
                totalDamage += number;
            }

            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == '*')
                {
                    totalDamage *= 2;
                }
                if (name[i] == '/')
                {
                    totalDamage /= 2;
                }
            }

            demon.Damage = totalDamage;
            demons.Add(demon);
        }

        var orderedDemons = demons.OrderBy(x => x.Name);

        foreach (var demon in orderedDemons)
        {
            Console.WriteLine("{0} - {1} health, {2:F2} damage", 
                demon.Name, demon.Health, demon.Damage);
        }
    }
}

public class Demon
{
    public string Name { get; set; }
    public long Health { get; set; }
    public decimal Damage { get; set; }
}

