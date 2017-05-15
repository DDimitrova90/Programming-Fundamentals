using System;
using System.Linq;

public class TrippleSum1
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        bool foundSum = false;

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                for (int k = 0; k < numbers.Length; k++)
                {
                    if (numbers[i] + numbers[j] == numbers[k])
                    {
                        Console.WriteLine($"{numbers[i]} + {numbers[j]} == {numbers[k]}");
                        foundSum = true;
                        break;
                    }
                }
            }
        }

        if (!foundSum)
        {
            Console.WriteLine("No");
        }
    }
}
