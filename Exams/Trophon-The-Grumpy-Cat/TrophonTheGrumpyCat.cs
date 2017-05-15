using System;
using System.Linq;      //https://judge.softuni.bg/Contests/Practice/Index/285#1

public class TrophonTheGrumpyCat
{
    public static void Main()
    {
        int[] priceRatings = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
        int entryPoint = int.Parse(Console.ReadLine());
        string itemsTypeToBreak = Console.ReadLine();
        string priceRatingsType = Console.ReadLine();

        int currRate = priceRatings[entryPoint];
        long leftRatingsSum = 0;
        long rightRatingsSum = 0;

        for (int i = 0; i < entryPoint; i++)
        {
            if (itemsTypeToBreak == "cheap" && priceRatings[i] < currRate)
            {
                if (priceRatingsType == "positive"  && priceRatings[i] > 0)
                {
                    leftRatingsSum += priceRatings[i];
                }
                else if (priceRatingsType == "negative" && priceRatings[i] < 0)
                {
                    leftRatingsSum += priceRatings[i];
                }
                else if (priceRatingsType == "all")
                {
                    leftRatingsSum += priceRatings[i];
                }
            }
            else if (itemsTypeToBreak == "expensive" && priceRatings[i] >= currRate)
            {
                if (priceRatingsType == "positive" && priceRatings[i] > 0)
                {
                    leftRatingsSum += priceRatings[i];
                }
                else if (priceRatingsType == "negative" && priceRatings[i] < 0)
                {
                    leftRatingsSum += priceRatings[i];
                }
                else if (priceRatingsType == "all")
                {
                    leftRatingsSum += priceRatings[i];
                }
            }
        }

        for (int i = entryPoint + 1; i < priceRatings.Length; i++)
        {
            if (itemsTypeToBreak == "cheap" && priceRatings[i] < currRate)
            {
                if (priceRatingsType == "positive" && priceRatings[i] > 0)
                {
                    rightRatingsSum += priceRatings[i];
                }
                else if (priceRatingsType == "negative" && priceRatings[i] < 0)
                {
                    rightRatingsSum += priceRatings[i];
                }
                else if (priceRatingsType == "all")
                {
                    rightRatingsSum += priceRatings[i];
                }
            }
            else if (itemsTypeToBreak == "expensive" && priceRatings[i] >= currRate)
            {
                if (priceRatingsType == "positive" && priceRatings[i] > 0)
                {
                    rightRatingsSum += priceRatings[i];
                }
                else if (priceRatingsType == "negative" && priceRatings[i] < 0)
                {
                    rightRatingsSum += priceRatings[i];
                }
                else if (priceRatingsType == "all")
                {
                    rightRatingsSum += priceRatings[i];
                }
            }
        }

        if (leftRatingsSum >= rightRatingsSum)
        {
            Console.WriteLine($"Left - {leftRatingsSum}");
        }
        else
        {
            Console.WriteLine($"Right - {rightRatingsSum}");
        }
    }
}

