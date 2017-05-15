using System;
using System.Numerics;

public class BigFactorial
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        BigInteger factorial = GetBigFactorial(number);

        Console.WriteLine(factorial);
    }

    private static BigInteger GetBigFactorial(int number)
    {
        BigInteger factorial = 1;

        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        return factorial;
    }
}

