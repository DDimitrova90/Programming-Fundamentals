using System;
using System.Collections.Generic;
using System.Linq;

class ArrayManipulator
{
    static void Main()
    {
        List<long> numbers = Console.ReadLine()
            .Split(' ')
            .Select(long.Parse)
            .ToList();

        string[] commands = Console.ReadLine().Split(' ');

        string action = commands[0];
        int index = 0;
        long element = 0;
        int position = 0;

        while (action != "print")
        {
            if (action == "add")
            {
                index = int.Parse(commands[1]);
                element = long.Parse(commands[2]);
                numbers.Insert(index, element);
            }
            else if (action == "addMany")
            {
                List<long> collection = new List<long>();

                for (int i = 2; i <= commands.Length - 1; i++)
                {
                    collection.Add(long.Parse(commands[i]));
                }

                index = int.Parse(commands[1]);
                numbers.InsertRange(index, collection);
            }
            else if (action == "contains")
            {
                element = long.Parse(commands[1]);
                long indexContains = numbers.IndexOf(element);
                Console.WriteLine(indexContains);
            }
            else if (action == "remove")
            {
                index = int.Parse(commands[1]);
                numbers.RemoveAt(index);
            }
            else if (action == "shift")
            {
                position = int.Parse(commands[1]);
                List<long> result = numbers.GetRange(position, numbers.Count - position);
                result.AddRange(numbers.GetRange(0, position));
                numbers = result;

                //for (int i = position; i < numbers.Count; i++)
                //{
                //    result[i - position] = numbers[i];
                //}
                //for (int i = numbers.Count - position; i < numbers.Count; i++)
                //{
                //    result[i] = numbers[i - numbers.Count + position];
                //}
            }
            else if (action == "sumPairs")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    numbers[i] = numbers[i] + numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                }
            }

            commands = Console.ReadLine().Split(' ');
            action = commands[0];
        }

        Console.WriteLine("[" + string.Join(", ", numbers) + "]");    
    }
}

