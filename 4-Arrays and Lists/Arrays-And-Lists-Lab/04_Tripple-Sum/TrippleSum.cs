using System;
using System.Linq;

public class TrippleSum
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        bool containsTrippleSum = false;

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                int sum = numbers[i] + numbers[j];

                if (numbers.Contains(sum))
                {
                    Console.WriteLine($"{numbers[i]} + {numbers[j]} == {sum}");
                    containsTrippleSum = true;
                }          
            }
        }

        if (!containsTrippleSum)
        {
            Console.WriteLine("No");
        }
    }
}

