using System;
using System.Linq;

class RoundingNumbers
{
    static void Main()
    {
        double[] numbers = Console.ReadLine()
            .Split(' ')
            .Select(number => double.Parse(number))
            .ToArray();

        RoundNumsAwayFromZero(numbers);
    }

    static void RoundNumsAwayFromZero(double[] numbers)
    {
        foreach (double number in numbers)
        {
            Console.WriteLine("{0} => {1}", 
                number, Math.Round(number, MidpointRounding.AwayFromZero));
            // or
            //Console.WriteLine("{0} => {0:F0}", number);
        }
    }
}

