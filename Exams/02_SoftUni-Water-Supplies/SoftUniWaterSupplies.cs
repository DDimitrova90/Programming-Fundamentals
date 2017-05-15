using System;
using System.Collections.Generic;    // https://judge.softuni.bg/Contests/Practice/Index/218#1
using System.Linq;

public class SoftUniWaterSupplies
{
    public static void Main()
    {
        int waterAmount = int.Parse(Console.ReadLine());
        decimal[] bottles = Console.ReadLine()
            .Split(' ')
            .Select(decimal.Parse)
            .ToArray();
        int bottleCapacity = int.Parse(Console.ReadLine());

        decimal usedWater = 0;
        int emptyBottles = 0;
        List<int> membersWithoutWater = new List<int>();

        if (waterAmount % 2 == 0)
        {
            for (int i = 0; i < bottles.Length; i++)
            {
                usedWater += bottleCapacity - bottles[i];

                if (usedWater > waterAmount)
                {
                    emptyBottles++;
                    membersWithoutWater.Add(i);
                }
            }
        }
        else
        {
            for (int i = bottles.Length - 1; i >= 0; i--)
            {
                usedWater += bottleCapacity - bottles[i];

                if (usedWater > waterAmount)
                {
                    emptyBottles++;
                    membersWithoutWater.Add(i);
                }
            }
        }

        if (usedWater <= waterAmount)
        {
            Console.WriteLine("Enough water!");
            Console.WriteLine("Water left: {0}l.", waterAmount - usedWater);
        }
        else
        {
            Console.WriteLine("We need more water!");
            Console.WriteLine("Bottles left: {0}", emptyBottles);
            Console.WriteLine("With indexes: " + string.Join(", ", membersWithoutWater));
            Console.WriteLine("We need {0} more liters!", usedWater - waterAmount);
        }
    }
}

