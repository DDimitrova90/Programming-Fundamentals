using System;

class HelloName
{
    static void Main()
    {
        string name = string.Empty;
        Console.WriteLine("Hello, {0}!", PrintName(name));
    }

    static string PrintName(string name)
    {
        name = Console.ReadLine();
        return name;
    }
}

