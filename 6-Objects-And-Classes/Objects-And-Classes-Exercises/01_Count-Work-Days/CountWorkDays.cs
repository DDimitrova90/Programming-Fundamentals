using System;
using System.Globalization;
using System.Linq;

public class CountWorkDays
{
    public static void Main()
    {
        string firstDate = Console.ReadLine();
        string secondDate = Console.ReadLine();

        DateTime startDate = DateTime.ParseExact(firstDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
        DateTime endDate = DateTime.ParseExact(secondDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);

        DateTime[] holidays = new DateTime[]
        {
            new DateTime(4, 01, 01),
            new DateTime(4, 03, 03),
            new DateTime(4, 05, 01),
            new DateTime(4, 05, 06),
            new DateTime(4, 05, 24),
            new DateTime(4, 09, 06),
            new DateTime(4, 09, 22),
            new DateTime(4, 11, 01),
            new DateTime(4, 12, 24),
            new DateTime(4, 12, 25),
            new DateTime(4, 12, 26)
        };

        int workingDaysCounter = 0;

        for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
        {
            DateTime tempDate = new DateTime(4, date.Month, date.Day);

            if (date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday && !holidays.Contains(tempDate))
            {
                workingDaysCounter++;
            }
        }

        Console.WriteLine(workingDaysCounter);
    }
}

