using System;
using System.IO;
using System.Linq;

public class MaxSequenceOfEqualElements
{
    public static void Main()
    {
        string input = Console.ReadLine();
        int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

        int len = 1;
        int bestLen = 1;
        int start = 0;
        int bestStart = 0;

        File.WriteAllText("Input.txt", "");
        File.WriteAllText("Input.txt", input);
        File.WriteAllText("Output.txt", "");

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] == numbers[i + 1])
            {
                len++;
            }
            else
            {
                len = 1;
                start = i + 1;
            }

            if (len > bestLen)
            {
                bestLen = len;
                bestStart = start;
            }
        }

        for (int i = bestStart; i < bestStart + bestLen; i++)
        {
            File.AppendAllText("Output.txt", $"{numbers[i]} ");
            Console.Write(numbers[i] + " ");
        }
    }
}

