using System;

class HelloName
{
    static void Main()
    {
        string firstName = Console.ReadLine();

        PrintsGreeting(firstName);
    }

    static void PrintsGreeting(string firstName)
    {
        Console.WriteLine($"Hello, {firstName}!");
    }
}

