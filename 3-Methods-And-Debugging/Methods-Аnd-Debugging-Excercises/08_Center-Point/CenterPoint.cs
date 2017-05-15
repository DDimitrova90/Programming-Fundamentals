using System;

class CenterPoint
{
    static void Main()
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        PrintClosestPoint(x1, y1, x2, y2);
    }

    static void PrintClosestPoint(double x1, double y1, double x2, double y2)
    {
        double firstPointDistnace = Math.Sqrt(Math.Pow(x1 - 0, 2) + Math.Pow(y1 - 0, 2));
        double secondPointDistance = Math.Sqrt(Math.Pow(x2 - 0, 2) + Math.Pow(y2 - 0, 2));

        if (firstPointDistnace <= secondPointDistance)
        {
            Console.WriteLine($"({x1}, {y1})");
        }
        else
        {
            Console.WriteLine($"({x2}, {y2})");
        }
    }
}
