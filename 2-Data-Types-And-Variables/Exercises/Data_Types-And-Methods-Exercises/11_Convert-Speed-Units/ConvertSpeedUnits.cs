using System;

class ConvertSpeedUnits
{
    static void Main()
    {
        int distanceMeters = int.Parse(Console.ReadLine());
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        int seconds = int.Parse(Console.ReadLine());

        int totalSeconds = seconds + (minutes * 60) + (hours * 60 * 60);
        float metersPerSecs = (float)distanceMeters / totalSeconds;
        float totalHours = hours + ((float)minutes / 60) + (((float)seconds / 60) / 60);
        float distanceKm = (float)distanceMeters / 1000;
        float kmPerHours = distanceKm / totalHours;
        float distanceMiles = (float)distanceMeters / 1609;
        float milesPerHours = distanceMiles / totalHours;

        Console.WriteLine(metersPerSecs);
        Console.WriteLine(kmPerHours);
        Console.WriteLine(milesPerHours);
    }
}

