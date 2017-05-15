using System;

class TheaThePhotographer    
{
    static void Main()
    {
        long takenPics = long.Parse(Console.ReadLine());
        long filterTimePerPic = long.Parse(Console.ReadLine());
        long filterFactor = long.Parse(Console.ReadLine());
        long uploadTimePerPic = long.Parse(Console.ReadLine());

        long goodPics = (long)Math.Ceiling((filterFactor / 100.0) * takenPics);
        long totalFilterTime = takenPics * filterTimePerPic;
        long totalUploadTime = goodPics * uploadTimePerPic;
        long totalTimeNeeded = totalFilterTime + totalUploadTime;

        long days = totalTimeNeeded / (60 * 60 * 24);
        totalTimeNeeded = totalTimeNeeded - (days * 60 * 60 * 24);
        long hours = totalTimeNeeded / (60 * 60);
        totalTimeNeeded = totalTimeNeeded - (hours * 60 * 60);
        long minutes = totalTimeNeeded / 60;
        long seconds = totalTimeNeeded - (minutes * 60);

        Console.WriteLine("{0}:{1:00}:{2:00}:{3:00}", days, hours, minutes, seconds);

        //TimeSpan timeSpan = TimeSpan.FromSeconds(totalTimeNeeded);
        //Console.WriteLine("{0:D1}:{1:D2}:{2:D2}:{3:D2}", timeSpan.Days, timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
    }
}

