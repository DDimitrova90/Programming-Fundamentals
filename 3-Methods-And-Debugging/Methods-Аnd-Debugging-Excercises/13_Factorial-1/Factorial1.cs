using System;
using System.Numerics;

public class Factorial1
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        BigInteger result = CalculateFactorial(number);

        Console.WriteLine(result);
    }

    static BigInteger CalculateFactorial(int number)
    {
        BigInteger factorial = 1;

        for (int i = 1; i <= number; i++)
        {
            factorial = factorial * i;
        }

        return factorial;
    }
}

