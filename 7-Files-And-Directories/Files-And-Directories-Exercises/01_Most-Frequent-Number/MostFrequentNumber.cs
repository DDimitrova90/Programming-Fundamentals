using System;
using System.IO;
using System.Linq;

public class MostFrequentNumber
{
    public static void Main()
    {
        string nums = Console.ReadLine();
        int[] numbers = nums.Split(' ').Select(int.Parse).ToArray();

        int mostFrequentNumber = 0;
        int maxFrequency = 1;

        File.WriteAllText("Input.txt", "");
        File.WriteAllText("Input.txt", nums);
        File.WriteAllText("Output.txt", "");

        for (int i = 0; i < numbers.Length; i++)
        {
            int frequencyCounter = 1;

            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[i] == numbers[j] && i != j)
                {
                    frequencyCounter++;
                }

                if (frequencyCounter > maxFrequency)
                {
                    maxFrequency = frequencyCounter;
                    mostFrequentNumber = numbers[i];
                }
            }
        }

        File.WriteAllText("Output.txt", mostFrequentNumber.ToString());
        Console.WriteLine(mostFrequentNumber);
    }
}

