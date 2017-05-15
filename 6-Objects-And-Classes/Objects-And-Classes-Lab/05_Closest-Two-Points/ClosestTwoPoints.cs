using System;
using System.Linq;

public class ClosestTwoPoints
{
    public static void Main()
    {
        Point[] points = ReadPoints();
        Point[] closestPoints = FindClosestTwoPoints(points);

        PrintDistance(closestPoints);

        PrintPoint(closestPoints[0]);
        PrintPoint(closestPoints[1]);
    }

    private static void PrintDistance(Point[] points)
    {
        double distance = CalcDistance(points[0], points[1]);

        Console.WriteLine("{0:F3}", distance);
    }

    static Point[] FindClosestTwoPoints(Point[] points)
    {
        double minDistance = double.MaxValue;
        Point[] closestTwoPoints = new Point[2];

        for (int p1 = 0; p1 < points.Length; p1++)
        {
            for (int p2 = p1 + 1; p2 < points.Length; p2++)
            {
                double distance = CalcDistance(points[p1], points[p2]);

                if (distance < minDistance)
                {
                    minDistance = distance;
                    closestTwoPoints[0] = points[p1];
                    closestTwoPoints[1] = points[p2];
                }
            }
        }

        return closestTwoPoints;
    }

    private static double CalcDistance(Point point1, Point point2)
    {
        int deltaX = Math.Abs(point1.X - point2.X);
        int deltaY = Math.Abs(point1.Y - point2.Y);
        double distance = Math.Sqrt((deltaX * deltaX) + (deltaY * deltaY));

        return distance;
    }

    static Point[] ReadPoints()
    {
        int n = int.Parse(Console.ReadLine());

        Point[] points = new Point[n];

        for (int i = 0; i < n; i++)
        {
            points[i] = ReadPoint();
        }

        return points;
    }

    static Point ReadPoint()
    {
        int[] pointsInfo = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        Point point = new Point();

        point.X = pointsInfo[0];
        point.Y = pointsInfo[1];

        return point;
    }

    static void PrintPoint(Point point)
    {
        Console.WriteLine("({0}, {1})", point.X, point.Y);
    }
}

class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}

