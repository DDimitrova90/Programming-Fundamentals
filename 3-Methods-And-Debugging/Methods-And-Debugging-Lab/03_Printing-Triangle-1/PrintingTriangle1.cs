using System;

class PrintingTriangle1
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        PrintTriangle(number);
    }

    static void PrintLine(int start, int end)
    {
        for (int i = start; i <= end; i++)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();
    }

    static void PrintTriangle(int number)
    {
        for (int i = 1; i <= number; i++)
        {
            PrintLine(1, i);
        }

        for (int i = number - 1; i >= 1; i--)
        {
            PrintLine(1, i);
        }
    }
}


