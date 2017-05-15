using System;
using System.Collections.Generic;
using System.Linq;

public class ArrayManipulator
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
        string input = Console.ReadLine();

        while (input != "end")
        {
            string[] commandInfo = input.Split(' ');
            string command = commandInfo[0];

            if (command == "exchange")
            {
                numbers = ExchangeArrayElements(numbers, commandInfo);
            }
            else if (command == "max")
            {
                int maxElementIndex = GetIndexOfMaxEvenOddElement(numbers, commandInfo);

                if (maxElementIndex >= 0)
                {
                    Console.WriteLine(maxElementIndex);
                }
            }
            else if (command == "min")
            {
                int minElementIndex = GetIndexOfMinEvenOddElement(numbers, commandInfo);

                if (minElementIndex >= 0)
                {
                    Console.WriteLine(minElementIndex);
                }
            }
            else if (command == "first")
            {
                List<int> firstElements = GetFirstEvenOddElements(numbers, commandInfo);
                int count = int.Parse(commandInfo[1]);

                if (firstElements.Contains(-1))
                {
                    Console.WriteLine("Invalid count");
                }
                else if (firstElements.Count == 0)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    int len = Math.Min(count, firstElements.Count);
                    firstElements = firstElements.Take(len).ToList();
                    Console.WriteLine("[" + string.Join(", ", firstElements) + "]");
                }
            }
            else if (command == "last")
            {
                List<int> lastElements = GetLastEvenOddElements(numbers, commandInfo);
                int count = int.Parse(commandInfo[1]);

                if (lastElements.Contains(-1))
                {
                    Console.WriteLine("Invalid count");
                }
                else if (lastElements.Count == 0)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    int len = Math.Min(count, lastElements.Count);
                    lastElements = lastElements.Take(len).ToList();
                    Console.WriteLine("[" + string.Join(", ", lastElements) + "]");
                }
            }

            input = Console.ReadLine();
        }

        Console.WriteLine("[" + string.Join(", ", numbers) + "]");
    }

    static List<int> GetLastEvenOddElements(int[] numbers, string[] commandInfo)
    {
        int count = int.Parse(commandInfo[1]);
        string type = commandInfo[2];
        List<int> lastElements = new List<int>();

        if (count <= 0 || count > numbers.Length)
        {
            lastElements.Add(-1);
        }
        else
        {
            if (type == "even")
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        lastElements.Add(numbers[i]);
                    }
                }
            }
            else if (type == "odd")
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 != 0)
                    {
                        lastElements.Add(numbers[i]);
                    }
                }
            }
        }

        return lastElements;
    }

    static List<int> GetFirstEvenOddElements(int[] numbers, string[] commandInfo)
    {
        int count = int.Parse(commandInfo[1]);
        string type = commandInfo[2];
        List<int> firstElements = new List<int>();

        if (count <= 0 || count > numbers.Length)
        {
            firstElements.Add(-1);
        }
        else
        {
            if (type == "even")
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        firstElements.Add(numbers[i]);
                    }
                }
            }
            else if (type == "odd")
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 != 0)
                    {
                        firstElements.Add(numbers[i]);
                    }
                }
            }
        }

        return firstElements;
    }

    static int GetIndexOfMinEvenOddElement(int[] numbers, string[] commandInfo)
    {
        string type = commandInfo[1];
        int currNum = 0;
        int minNum = int.MaxValue;
        int index = -1;
        bool hasMatch = false;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (type == "even")
            {
                if (numbers[i] % 2 == 0)
                {
                    currNum = numbers[i];
                    hasMatch = true;

                    if (currNum <= minNum)
                    {
                        index = i;
                        minNum = currNum;
                    }
                }
            }
            else if (type == "odd")
            {
                if (numbers[i] % 2 != 0)
                {
                    currNum = numbers[i];
                    hasMatch = true;

                    if (currNum <= minNum)
                    {
                        index = i;
                        minNum = currNum;
                    }
                }
            }
        }

        if (!hasMatch)
        {
            Console.WriteLine("No matches");
        }

        return index;
    }

    static int GetIndexOfMaxEvenOddElement(int[] numbers, string[] commandInfo)
    {
        string type = commandInfo[1];
        int currNum = 0;
        int maxNum = int.MinValue;
        int index = -1;
        bool hasMatch = false;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (type == "even")
            {
                if (numbers[i] % 2 == 0)
                {
                    currNum = numbers[i];
                    hasMatch = true;

                    if (currNum >= maxNum)
                    {
                        index = i;
                        maxNum = currNum;
                    }
                }
            }
            else if (type == "odd")
            {
                if (numbers[i] % 2 != 0)
                {
                    currNum = numbers[i];
                    hasMatch = true;

                    if (currNum >= maxNum)
                    {
                        index = i;
                        maxNum = currNum;
                    }
                }
            }
        }

        if (!hasMatch)
        {
            Console.WriteLine("No matches");
        }

        return index;
    }

    static int[] ExchangeArrayElements(int[] numbers, string[] commandInfo)
    {
        int index = int.Parse(commandInfo[1]);
        int shifts = numbers.Length - (index + 1);

        if (index < 0 || index >= numbers.Length)
        {
            Console.WriteLine("Invalid index");
        }
        else
        {
            for (int currShift = 0; currShift < shifts; currShift++)
            {
                int[] temp = new int[numbers.Length];

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    temp[i + 1] = numbers[i];
                }

                temp[0] = numbers[numbers.Length - 1];
                numbers = temp;
            }
        }
        
        return numbers;
    }
}

