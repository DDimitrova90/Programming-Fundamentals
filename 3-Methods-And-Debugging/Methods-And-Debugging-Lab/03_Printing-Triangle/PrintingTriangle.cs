using System;

class PrintingTriangle
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            PrintLine(i);
        }

        for (int i = n - 1; i >=0; i--)
        {
            PrintLine(i);
        }
        
    }

    static void PrintLine(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();
    }
}

