using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

public class ConvertFromBase10ToBaseN
{
    public static void Main()
    {
        BigInteger[] input = Console.ReadLine()
            .Split(' ')
            .Select(BigInteger.Parse)
            .ToArray();

        BigInteger currBase = input[0];
        BigInteger number = input[1];
        List<BigInteger> remainders = new List<BigInteger>();

        BigInteger result = number / currBase;
        BigInteger remainder = 0;

        while (result > 0)
        {
            remainder = number % currBase;
            remainders.Add(remainder);
            number = result;

            result = number / currBase;
        }

        remainder = number % currBase;
        remainders.Add(remainder);
        remainders.Reverse();

        Console.WriteLine(string.Join("", remainders));
    }
}

