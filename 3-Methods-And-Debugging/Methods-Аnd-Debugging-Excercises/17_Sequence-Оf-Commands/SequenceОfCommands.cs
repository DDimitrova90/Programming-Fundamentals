using System;
using System.Linq;

public class SequenceOfCommands_broken
{
    private const char ArgumentsDelimiter = ' ';

    public static void Main()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());

        long[] array = Console.ReadLine()
            .Split(ArgumentsDelimiter)
            .Select(long.Parse)
            .ToArray();

        string[] command = Console.ReadLine().Split(' ');
        string action = command[0];

        while (!action.Equals("stop"))
        {
            int[] args = new int[2];

            if (action.Equals("add") ||
                action.Equals("subtract") ||
                action.Equals("multiply"))
            {
                args[0] = int.Parse(command[1]);
                args[1] = int.Parse(command[2]);
            }

            array = PerformAction(array, action, args);
            PrintArray(array);
            Console.WriteLine();

            command = Console.ReadLine().Split(' ');
            action = command[0];
        }
    }

    static long[] PerformAction(long[] arr, string action, int[] args)
    {
        long[] array = arr.Clone() as long[];
        int pos = args[0] - 1;
        int value = args[1];

        switch (action)
        {
            case "multiply":
                array[pos] *= value;
                break;
            case "add":
                array[pos] += value;
                break;
            case "subtract":
                array[pos] -= value;
                break;
            case "lshift":
                return array = ArrayShiftLeft(array);
            case "rshift":
               return array = ArrayShiftRight(array);
        }

        return array;
    }

    private static long[] ArrayShiftRight(long[] array)
    {
        long[] demo = new long[array.Length];

        for (int i = 1; i < array.Length; i++)
        {
            demo[i] = array[i - 1];
        }

        demo[0] = array[demo.Length - 1];
        array = demo;

        return array;
    }

    private static long[] ArrayShiftLeft(long[] array)
    {
        long[] demo = new long[array.Length];

        for (int i = 0; i < array.Length - 1; i++)
        {
            demo[i] = array[i + 1];
        }

        demo[demo.Length - 1] = array[0];
        array = demo;
        
        return array;
    }

    private static void PrintArray(long[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}

