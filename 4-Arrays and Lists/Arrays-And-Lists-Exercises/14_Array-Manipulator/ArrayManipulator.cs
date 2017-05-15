using System;
using System.Collections.Generic;
using System.Linq;

public class ArrayManipulator
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        string[] input = Console.ReadLine().Split(' ');
        string command = input[0];

        while (command != "print")
        {
            numbers = ExecutesCommand(numbers, command, input);

            input = Console.ReadLine().Split(' ');
            command = input[0];
        }

        Console.WriteLine("[" + string.Join(", ", numbers) + "]");
    }

    static List<int> ExecutesCommand(List<int> numbers, string command, string[] input)
    {
        switch (command)
        {
            case "add":
                int index = int.Parse(input[1]);
                int element = int.Parse(input[2]);
                numbers.Insert(index, element);
                break;
            case "addMany":
                index = int.Parse(input[1]);
                List<int> elements = new List<int>();

                for (int i = 2; i < input.Length; i++)
                {
                    elements.Add(int.Parse(input[i]));
                }

                numbers.InsertRange(index, elements);
                break;
            case "contains":
                element = int.Parse(input[1]);
                index = numbers.IndexOf(element);
                Console.WriteLine(index);
                break;
            case "remove":
                index = int.Parse(input[1]);
                numbers.RemoveAt(index);
                break;
            case "shift":
                int position = int.Parse(input[1]);
                int temp = 0;
                for (int i = 0; i < position; i++)
                {
                    temp = numbers[0];
                    numbers.RemoveAt(0);
                    numbers.Add(temp);
                }
                break;
            case "sumPairs":
                List<int> summed = new List<int>();
                while (numbers.Count >= 2)
                {
                    summed.Add(numbers[0] + numbers[1]);
                    numbers.RemoveAt(0);
                    numbers.RemoveAt(0);
                }
                if (numbers.Count == 1) summed.Add(numbers[0]);

                numbers = summed;
                break;
        }

        return numbers;
    }
}
