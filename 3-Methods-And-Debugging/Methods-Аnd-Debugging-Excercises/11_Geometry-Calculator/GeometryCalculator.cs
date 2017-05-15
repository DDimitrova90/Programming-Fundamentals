using System;

public class GeometryCalculator
{
    public static void Main()
    {
        string figureType = Console.ReadLine();
        double side = 0;
        double height = 0;
        double width = 0;
        double radius = 0;
        double result = 0;

        if (figureType == "triangle")
        {
            side = double.Parse(Console.ReadLine());
            height = double.Parse(Console.ReadLine());
            result = GetTriangleArea(side, height);
        }
        else if (figureType == "square")
        {
            side = double.Parse(Console.ReadLine());
            result = GetSquareArea(side);
        }
        else if (figureType == "rectangle")
        {
            width = double.Parse(Console.ReadLine());
            height = double.Parse(Console.ReadLine());
            result = GetRectangleArea(width, height);
        }
        else
        {
            radius = double.Parse(Console.ReadLine());
            result = GetCircleArea(radius);
        }

        Console.WriteLine("{0:F2}", result);
    }

    static double GetTriangleArea(double side, double height)
    {
        return (side * height) / 2;       
    }

    static double GetSquareArea(double side)
    {
        return side * side;
    }

    static double GetRectangleArea(double width, double height)
    {
        return width * height;
    }

    static double GetCircleArea(double radius)
    {
        return Math.PI * radius * radius;
    }
}

