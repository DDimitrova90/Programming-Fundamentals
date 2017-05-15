using System;
using System.Linq;

public class MostFrequentNumber
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        int mostFreqNum = GetMostFrequentNumber(numbers);

        Console.WriteLine(mostFreqNum);
    }

    static int GetMostFrequentNumber(int[] numbers)
    {    
        int maxOccurance = 0;
        int mostFreqNum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            int occurance = 0;

            foreach (var number in numbers)
            {
                if (numbers[i] == number)
                {
                    occurance++;
                }
            }

            if (occurance > maxOccurance)
            {
                maxOccurance = occurance;
                mostFreqNum = numbers[i];
            }
        }

        return mostFreqNum;
    }
}

