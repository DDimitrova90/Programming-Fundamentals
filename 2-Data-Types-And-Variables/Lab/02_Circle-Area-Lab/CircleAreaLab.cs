using System;

class CircleAreaLab
{
    static void Main()
    {
        double radius = double.Parse(Console.ReadLine());
        double circleArea = Math.PI * radius * radius;

        Console.WriteLine("{0:F12}", circleArea);
    }
}

