using System;

class CalculateTriangleArea
{
    static void Main()
    {
        double baseSide = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double triangleArea = GetTriangleArea(baseSide, height);
        Console.WriteLine(triangleArea); 
    }

    static double GetTriangleArea(double baseSide, double height)
    {
        return (baseSide * height) / 2;
    }
}

