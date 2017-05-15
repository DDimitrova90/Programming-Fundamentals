using System;

class DrawAFilledSquare
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        PrintTopBottom(n);

        for (int i = 0; i < n - 2; i++)
        {
            PrintMiddlePart(n);
        }

        PrintTopBottom(n);
    }

    static void PrintTopBottom(int n)
    {
        Console.WriteLine(new string('-', 2 * n));
    }

    static void PrintMiddlePart(int n)
    {
        Console.Write("-");

        for (int i = 0; i < n - 1; i++)
        {
            Console.Write("\\/");
        }

        Console.WriteLine("-");
    }
}

