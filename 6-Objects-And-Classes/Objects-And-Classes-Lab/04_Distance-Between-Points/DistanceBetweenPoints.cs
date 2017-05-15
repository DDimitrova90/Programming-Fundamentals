using System;
using System.Linq;

public class DistanceBetweenPoints
{
    public static void Main()
    {
        Point p1 = ReadPoint();
        Point p2 = ReadPoint();

        double distance = CalcDistance(p1, p2);

        Console.WriteLine("{0:F3}", distance);
    }

    static double CalcDistance(Point p1, Point p2)
    {
        int deltaX = Math.Abs(p1.X - p2.X);
        int deltaY = Math.Abs(p1.Y - p2.Y);
        double distance = Math.Sqrt((deltaX * deltaX) + (deltaY * deltaY));

        return distance;
    }

    static Point ReadPoint()
    {
        int[] pointsInfo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Point point = new Point();
        point.X = pointsInfo[0];
        point.Y = pointsInfo[1];

        return point;
    }
}

public class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}

