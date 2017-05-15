using System;
using System.Collections.Generic;    // https://judge.softuni.bg/Contests/Practice/Index/218#2
using System.Linq;

public class MatrixOperator
{
    public static void Main()
    {
        int rows = int.Parse(Console.ReadLine());

        List<List<long>> matrix = new List<List<long>>();

        for (int row = 0; row < rows; row++)
        {
            List<long> currRow = new List<long>();
            currRow = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToList();
            matrix.Add(currRow);
        }

        string input = Console.ReadLine();

        while (input != "end")
        {
            string[] commandsArgs = input.Split(' ');
            string command = commandsArgs[0];

            if (command == "remove")
            {
                PerformCommandRemove(commandsArgs, matrix);
            }
            else if (command == "swap")
            {
                PerformCommandSwap(commandsArgs, matrix);
            }
            else if (command == "insert")
            {
                PerformCommandInsert(commandsArgs, matrix);
            }

            input = Console.ReadLine();
        }

        PrintMatrix(matrix);
    }

    static void PerformCommandInsert(string[] commandsArgs, List<List<long>> matrix)
    {
        int row = int.Parse(commandsArgs[1]);
        int number = int.Parse(commandsArgs[2]);

        matrix[row].Insert(0, number);
    }

    static void PrintMatrix(List<List<long>> matrix)
    {
        foreach (var list in matrix)
        {
            Console.WriteLine(string.Join(" ", list));
        }
    }

    static void PerformCommandSwap(string[] commandsArgs, List<List<long>> matrix)
    {
        int firstRow = int.Parse(commandsArgs[1]);
        int secondRow = int.Parse(commandsArgs[2]);
        List<long> temp = new List<long>();

        for (int i = 0; i < matrix[firstRow].Count; i++)
        {
            temp.Add(matrix[firstRow][i]);
        }

        matrix[firstRow].Clear();
        matrix[firstRow].AddRange(matrix[secondRow]);
        matrix[secondRow].Clear();
        matrix[secondRow].AddRange(temp);
    }

    static void PerformCommandRemove(string[] commandsArgs, List<List<long>> matrix)
    {
        string type = commandsArgs[1];
        string position = commandsArgs[2];
        int index = int.Parse(commandsArgs[3]);

        if (position == "row")
        {
            switch (type)
            {
                case "positive":
                    matrix[index].RemoveAll(x => x >= 0);
                    break;
                case "negative":
                    matrix[index].RemoveAll(x => x < 0);
                    break;
                case "odd":
                    matrix[index].RemoveAll(x => x % 2 != 0);
                    break;
                case "even":
                    matrix[index].RemoveAll(x => x % 2 == 0);
                    break;
            }
        }
        else if (position == "col")
        {
            foreach (var list in matrix)
            {
                if (index > list.Count - 1)
                {
                    continue;
                }

                switch (type)
                {
                    case "positive":
                        if (list[index] >= 0)
                        {
                            list.RemoveAt(index);
                        }
                        break;
                    case "negative":
                        if (list[index] < 0)
                        {
                            list.RemoveAt(index);
                        }
                        break;
                    case "odd":
                        if (list[index] % 2 != 0)
                        {
                            list.RemoveAt(index);
                        }
                        break;
                    case "even":
                        if (list[index] % 2 == 0)
                        {
                            list.RemoveAt(index);
                        }
                        break;
                }
            }
        }
    }
}

