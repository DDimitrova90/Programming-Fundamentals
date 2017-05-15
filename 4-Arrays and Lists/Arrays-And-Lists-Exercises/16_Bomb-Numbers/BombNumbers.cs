using System;
using System.Collections.Generic;
using System.Linq;

public class BombNumbers
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();
        string[] parameters = Console.ReadLine().Split(' ');
        int bombNumber = int.Parse(parameters[0]);
        int power = int.Parse(parameters[1]);

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == bombNumber)
            {
                int start = Math.Max(0, i - power);
                int end = Math.Min(i + power, numbers.Count - 1);
                int length = end - start + 1;
                numbers.RemoveRange(start, length);

                i = 0;
            }
        }

        int sum = 0;

        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
        }

        Console.WriteLine(sum);
    }
}

