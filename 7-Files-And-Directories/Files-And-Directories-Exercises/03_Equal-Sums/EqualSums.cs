using System;
using System.IO;
using System.Linq;

public class EqualSums
{
    public static void Main()
    {
        string input = Console.ReadLine();
        int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

        File.WriteAllText("Input.txt", "");
        File.WriteAllText("Input.txt", input);
        File.WriteAllText("Output.txt", "");

        bool noSuchNumber = true;

        for (int i = 0; i < numbers.Length; i++)
        {
            int leftSum = 0;
            int rightSum = 0;

            for (int j = 0; j < i; j++)
            {
                leftSum += numbers[j];
            }
            for (int k = i + 1; k < numbers.Length; k++)
            {
                rightSum += numbers[k];
            }

            if (leftSum == rightSum)
            {
                File.AppendAllText("Output.txt", $"{i}");
                Console.WriteLine(i);
                noSuchNumber = false;
            }
        }

        if (noSuchNumber)
        {
            File.AppendAllText("Output.txt", "no");
            Console.WriteLine("no");
        }
    }
}

