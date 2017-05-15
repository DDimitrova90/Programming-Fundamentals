using System;    // https://judge.softuni.bg/Contests/Practice/Index/332#0

public class SweetDessert
{
    public static void Main()
    {
        decimal cash = decimal.Parse(Console.ReadLine());
        int guestsNum = int.Parse(Console.ReadLine());
        decimal bananaPrice = decimal.Parse(Console.ReadLine());
        decimal eggPrice = decimal.Parse(Console.ReadLine());
        decimal berriesPricePerKilo = decimal.Parse(Console.ReadLine());

        int setsNum = guestsNum / 6;

        if (guestsNum % 6 != 0)
        {
            setsNum++;
        }

        decimal setPrice = (2 * bananaPrice) + (4 * eggPrice) + (0.2M * berriesPricePerKilo);
        decimal moneyNeeded = setPrice * setsNum;

        if (moneyNeeded <= cash)
        {
            Console.WriteLine("Ivancho has enough money - it would cost {0:F2}lv.", moneyNeeded);
        }
        else
        {
            Console.WriteLine("Ivancho will have to withdraw money - he will need {0:F2}lv more.", moneyNeeded - cash);
        }
    }
}

