using System;
using System.Linq;     // https://judge.softuni.bg/Contests/Practice/Index/217#0

public class Numbers
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        bool noSuchNums = true;
        double averageValue = numbers.Average();
        numbers = numbers.OrderByDescending(x => x).ToArray();

        for (int i = 0; i < 5; i++)
        {
            if (numbers[i] > averageValue)
            {
                Console.Write(numbers[i] + " ");
                noSuchNums = false;
            }
            else
            {
                break;
            }
        }

        if (noSuchNums)
        {
            Console.WriteLine("No");
        }
    }
}

