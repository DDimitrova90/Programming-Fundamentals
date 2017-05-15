using System;
using System.Linq;
using System.Numerics;

public class ConvertFromBaseNToBase10
{
    public static void Main()
    {
        BigInteger[] input = Console.ReadLine()
            .Split(' ')
            .Select(BigInteger.Parse)
            .ToArray();

        BigInteger currBase = input[0];
        BigInteger number = input[1];
        int degree = 0;                        
        BigInteger result = 0;                 // BigInteger multiplier = 1;               
                                               // multiplier *= currBase;
        while (number > 0)                     // result += lastDigit * multiplier;
        {
            BigInteger lastDigit = number % 10;
            result += lastDigit * BigInteger.Pow(currBase, degree);
            degree++;
            number = number / 10;
        }

        Console.WriteLine(result);
    }
}

