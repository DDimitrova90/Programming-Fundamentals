using System;
using System.Linq;

public class CirclesIntersection
{
    public static void Main()
    {
        Circle circle1 = ReadCircle();
        Circle circle2 = ReadCircle();

        bool areIntersected = Intersect(circle1, circle2);

        if (areIntersected)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }

    static bool Intersect(Circle circle1, Circle circle2)
    {
        int radiusesSum = circle1.Radius + circle2.Radius;
        double distance = CalcDistanceBetweenPoints(circle1, circle2);

        if (distance > radiusesSum)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    static double CalcDistanceBetweenPoints(Circle circle1, Circle circle2)
    {
        int deltaX = Math.Abs(circle1.Center.X - circle2.Center.X);
        int deltaY = Math.Abs(circle1.Center.Y - circle2.Center.Y);
        double distance = Math.Sqrt((deltaX * deltaX) + (deltaY * deltaY));

        return distance;
    }

    static Circle ReadCircle()
    {
        int[] circleInfo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Circle circle = new Circle();
        circle.Center = ReadPoint(circleInfo);
        circle.Radius = circleInfo[2];

        return circle;
    }

    static Point ReadPoint(int[] circleInfo)
    {
        Point point = new Point();
        point.X = circleInfo[0];
        point.Y = circleInfo[1];

        return point;
    }
}

public class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}

public class Circle
{
    public Point Center { get; set; }
    public int Radius { get; set; }
}

