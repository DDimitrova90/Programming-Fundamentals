using System;
using System.Globalization;    // https://judge.softuni.bg/Contests/Practice/Index/217#1

public class SoftuniCoffeeOrders
{
    public static void Main()
    {
        int orderCount = int.Parse(Console.ReadLine());

        decimal totalPrice = 0;

        for (int i = 0; i < orderCount; i++)
        {
            decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
            string date = Console.ReadLine();
            DateTime orderDate = DateTime.ParseExact(date, "d/M/yyyy", CultureInfo.InvariantCulture);
            long capsulesCount = long.Parse(Console.ReadLine());

            int daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
            decimal orderPrice = (daysInMonth * capsulesCount) * pricePerCapsule;
            totalPrice += orderPrice;

            Console.WriteLine("The price for the coffee is: ${0:F2}", orderPrice);
        }

        Console.WriteLine("Total: ${0:F2}", totalPrice);
    }
}

