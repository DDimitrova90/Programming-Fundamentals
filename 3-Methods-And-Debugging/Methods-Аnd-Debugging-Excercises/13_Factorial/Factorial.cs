using System;
using System.Numerics;

public class Factorial
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        BigInteger factorial = 1;

        for (int i = 1; i <= number; i++)
        {
            factorial = factorial * i;
        }

        Console.WriteLine(factorial);
    }
}

