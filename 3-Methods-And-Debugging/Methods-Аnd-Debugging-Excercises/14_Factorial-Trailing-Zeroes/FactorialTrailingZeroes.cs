using System;
using System.Numerics;

public class FactorialTrailingZeroes
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        BigInteger factorial = CalculateFactorial(number);
        int zeroCount = CountTrailingZeros(factorial);

        Console.WriteLine(zeroCount);
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

    static int CountTrailingZeros(BigInteger factorial)
    {
        int zeroCount = 0;

        while (factorial > 0)
        {
            int digit = (int)(factorial % 10);
            factorial = factorial / 10;

            if (digit == 0)
            {
                zeroCount++;
            }
            else
            {
                break;
            }
        }

        return zeroCount;
    }
}

