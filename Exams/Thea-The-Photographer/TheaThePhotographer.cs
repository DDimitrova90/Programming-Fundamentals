using System;     // https://judge.softuni.bg/Contests/Practice/Index/285#0

public class TheaThePhotographer
{
    public static void Main()
    {
        int picsAmount = int.Parse(Console.ReadLine());
        int filterTimePerPic = int.Parse(Console.ReadLine());
        int filterFactor = int.Parse(Console.ReadLine());
        int uploadTimePerPic = int.Parse(Console.ReadLine());

        long totalFilterTime = (long)filterTimePerPic * picsAmount;
        int goodPics = (int)Math.Ceiling(picsAmount * (filterFactor / 100.0));
        long totalUploadTime = (long)goodPics * uploadTimePerPic;
        long totalTime = totalFilterTime + totalUploadTime;

        long days = totalTime / 60 / 60 / 24;
        totalTime = totalTime - (days * 60 * 60 * 24);
        long hours = totalTime / 60 / 60;
        totalTime = totalTime - (hours * 60 * 60);
        long minutes = totalTime / 60;
        long seconds = totalTime - (minutes * 60);

        Console.WriteLine("{0}:{1:00}:{2:00}:{3:00}", days, hours, minutes, seconds);
    }
}

