using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        int c = a;
        a = b;
        b = c;

        Console.WriteLine("Before:");
        Console.WriteLine($"a = {b}");
        Console.WriteLine($"b = {a}");
        Console.WriteLine("After:");
        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");
    }
}

