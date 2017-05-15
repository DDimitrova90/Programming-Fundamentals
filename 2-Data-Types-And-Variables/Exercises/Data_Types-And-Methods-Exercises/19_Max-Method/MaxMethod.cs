using System;

class MaxMethod
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine(Math.Max(c, GetMax(a, b)));
    }

    static int GetMax(int a, int b)
    {
        int biggestNum = Math.Max(a, b);
        return biggestNum;
    }
}

