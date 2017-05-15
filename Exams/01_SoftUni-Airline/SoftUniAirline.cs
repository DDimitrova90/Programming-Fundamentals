using System;    // https://judge.softuni.bg/Contests/Practice/Index/218#0

public class SoftUniAirline
{
    public static void Main()
    {
        int flightsNumber = int.Parse(Console.ReadLine());

        decimal totalProfit = 0;

        for (int i = 0; i < flightsNumber; i++)
        {
            int adultPassCount = int.Parse(Console.ReadLine());
            decimal adultTicketPrice = decimal.Parse(Console.ReadLine());
            int youthPassCount = int.Parse(Console.ReadLine());
            decimal youthTicketPrice = decimal.Parse(Console.ReadLine());
            decimal fuelPricePerHour = decimal.Parse(Console.ReadLine());
            decimal fuelConsumPerHour = decimal.Parse(Console.ReadLine());
            int flightDuration = int.Parse(Console.ReadLine());

            decimal currIncome = (adultPassCount * adultTicketPrice) + (youthPassCount * youthTicketPrice);
            decimal currExpenses = fuelPricePerHour * fuelConsumPerHour * flightDuration;
            decimal currProfit = currIncome - currExpenses;
            totalProfit += currProfit;

            if (currIncome >= currExpenses)
            {
                Console.WriteLine("You are ahead with {0:F3}$.", currProfit);
            }
            else
            {
                Console.WriteLine("We've got to sell more tickets! We've lost {0:F3}$.", currProfit);
            }
        }

        decimal averageProfit = totalProfit / flightsNumber;

        Console.WriteLine("Overall profit -> {0:F3}$.", totalProfit);
        Console.WriteLine("Average profit -> {0:F3}$.", averageProfit);
    }
}

