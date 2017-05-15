using System;

public class CubeProperties
{
    public static void Main()
    {
        double side = double.Parse(Console.ReadLine());
        string parameter = Console.ReadLine();

        switch (parameter)
        {
            case "face":
                PrintFaceDiagonal(side);
                break;
            case "space":
                PrintSpaceDiagonal(side);
                break;
            case "volume":
                PrintCubeVolume(side);
                break;
            case "area":
                PrintCubeArea(side);
                break;
        }
    }

    static void PrintFaceDiagonal(double side)
    {
        double faceDiagonal = Math.Sqrt(2 * side * side);
        Console.WriteLine("{0:F2}", faceDiagonal);
    }

    static void PrintSpaceDiagonal(double side)
    {
        double spaceDiagonal = Math.Sqrt(3 * side * side);
        Console.WriteLine("{0:F2}", spaceDiagonal); 
    }

    static void PrintCubeVolume(double side)
    {
        double cubeVolume = side * side * side;
        Console.WriteLine("{0:F2}", cubeVolume);
    }

    static void PrintCubeArea(double side)
    {
        double cubeArea = 6 * side * side;
        Console.WriteLine("{0:F2}", cubeArea);
    }
}

