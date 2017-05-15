using System;
using System.Collections.Generic;
using System.Linq;

class BombNumbers1
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();
        int[] parameters = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        int bombNum = parameters[0];
        int bombPower = parameters[1];

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == bombNum)
            {
                numbers[i] = 0;

                for (int j = 1; j <= bombPower; j++)
                {
                    if (i + j > numbers.Count - 1)
                    {
                        break;
                    }
                    else
                    {
                        numbers[i + j] = 0;
                    }
                }

                for (int k = 1; k <= bombPower; k++)
                {
                    if (i - k < 0)
                    {
                        break;
                    }
                    else
                    {
                        numbers[i - k] = 0;
                    }
                }
            }
        }

        int sum = 0;

        foreach (var number in numbers)
        {
            sum += number;
        }

        Console.WriteLine(sum);
    }
}

