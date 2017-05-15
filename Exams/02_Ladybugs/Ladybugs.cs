using System;
using System.Linq;

public class Ladybugs
{
    public static void Main()
    {
        int fieldSize = int.Parse(Console.ReadLine());
        long[] field = new long[fieldSize];
        long[] indexes = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(long.Parse)
            .ToArray();

        for (int i = 0; i < field.Length; i++)
        {
            field[i] = 0;
        }

        foreach (var index in indexes)
        {
            if (IsInRange(index, fieldSize))
            {
                field[index] = 1;
            }
        }

        string command = Console.ReadLine();

        while (!command.Equals("end"))
        {
            string[] commandInfo = command
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            long startIndex = long.Parse(commandInfo[0]);
            string direction = commandInfo[1].ToLower();
            long len = long.Parse(commandInfo[2]);

            if (IsInRange(startIndex, fieldSize))
            {
                if (field[startIndex] == 1)
                {
                    if (direction == "right")
                    {
                        if (len > 0)
                        {
                            MoveRight(field, startIndex, Math.Abs(len), fieldSize);
                        }
                        else if (len < 0)
                        {
                            MoveLeft(field, startIndex, Math.Abs(len), fieldSize);
                        }
                    }
                    else if (direction == "left")
                    {
                        if (len > 0)
                        {
                            MoveLeft(field, startIndex, Math.Abs(len), fieldSize);
                        }
                        else if (len < 0)
                        {
                            MoveRight(field, startIndex, Math.Abs(len), fieldSize);
                        }
                    }
                }
            }

            command = Console.ReadLine();
        }

        Console.WriteLine(string.Join(" ", field));
    }

    private static void MoveLeft(long[] field, long startIndex, long len, int fieldSize)
    {
        field[startIndex] = 0;
        startIndex = startIndex - len;

        while (IsInRange(startIndex, fieldSize))
        {
            if (field[startIndex] == 0)
            {
                field[startIndex] = 1;
                break;
            }

            startIndex = startIndex - len;
        }
    }

    private static void MoveRight(long[] field, long startIndex, long len, int fieldSize)
    {
        field[startIndex] = 0;
        startIndex = startIndex + len;

        while (IsInRange(startIndex, fieldSize))
        {
            if (field[startIndex] == 0)
            {
                field[startIndex] = 1;
                break;
            }

            startIndex = startIndex + len;
        }
    }

    static bool IsInRange(long index, int fieldSize)
    {
        bool isInRange = true;

        if (index < 0)
        {
            isInRange = false;
        }
        else if (index >= fieldSize)
        {
            isInRange = false;
        }

        return isInRange;
    }
}

