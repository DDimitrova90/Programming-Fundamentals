using System;
using System.Linq;   // https://judge.softuni.bg/Contests/Practice/Index/215#1

public class ArrayModifier
{
    public static void Main()
    {
        long[] numbers = Console.ReadLine()
            .Split(' ')
            .Select(long.Parse)
            .ToArray();
        string input = Console.ReadLine();

        while (input != "end")
        {
            string[] commandInfo = input.Split(' ');
            string command = commandInfo[0];

            if (command == "swap")
            {
                numbers = SwapArrayElements(numbers, commandInfo);
            }
            else if (command == "multiply")
            {
                numbers = MultiplyArrayElements(numbers, commandInfo);
            }
            else if (command == "decrease")
            {
                numbers = DecreaseArrayElements(numbers, commandInfo);
            }

            input = Console.ReadLine();
        }

        Console.WriteLine(string.Join(", ", numbers));
    }

    static long[] DecreaseArrayElements(long[] numbers, string[] commandInfo)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i]--;
        }

        return numbers;
    }

    static long[] MultiplyArrayElements(long[] numbers, string[] commandInfo)
    {
        long firstIndex = long.Parse(commandInfo[1]);
        long secondIndex = long.Parse(commandInfo[2]);

        numbers[firstIndex] = numbers[firstIndex] * numbers[secondIndex];
        return numbers;
    }

    static long[] SwapArrayElements(long[] numbers, string[] commandInfo)
    {
        long firstIndex = long.Parse(commandInfo[1]);
        long secondIndex = long.Parse(commandInfo[2]);

        long temp = 0;
        temp = numbers[firstIndex];
        numbers[firstIndex] = numbers[secondIndex];
        numbers[secondIndex] = temp;

        return numbers;
    }
}

