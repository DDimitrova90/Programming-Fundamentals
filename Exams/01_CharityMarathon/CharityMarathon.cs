using System;       // https://judge.softuni.bg/Contests/Practice/Index/333#0

public class CharityMarathon
{
    public static void Main()
    {
        int days = int.Parse(Console.ReadLine());
        int runners = int.Parse(Console.ReadLine());
        int averageLaps = int.Parse(Console.ReadLine());
        int trackLength = int.Parse(Console.ReadLine());
        int trackCapacity = int.Parse(Console.ReadLine());
        decimal moneyPerKm = decimal.Parse(Console.ReadLine());

        long neededRunners = (long)days * trackCapacity;
        long totalMeters = 0;

        if (runners <= neededRunners)
        {
            totalMeters = (long)runners * averageLaps * trackLength;
        }
        else
        {
            totalMeters = (long)neededRunners * averageLaps * trackLength;
        }

        long totalKm = totalMeters / 1000;
        decimal donatedMoney = totalKm * moneyPerKm;

        Console.WriteLine("Money raised: {0:F2}", donatedMoney   );
    }
}

