using System;

class ExactSumOfRealNumbersLab
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        decimal exactSum = 0;

        for (int i = 0; i < n; i++)
        {
            decimal number = decimal.Parse(Console.ReadLine());
            exactSum += number;
        }

        Console.WriteLine(exactSum);
    }
}

