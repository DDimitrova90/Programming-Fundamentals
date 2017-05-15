using System;
using System.Linq;

class NumbersInReversedOrder
{
    static void Main()
    {
        string number = Console.ReadLine();

        PrintReversedOrderOfDigits(number);
    }

    static void PrintReversedOrderOfDigits(string number)
    {
        Console.WriteLine(string.Join("", number.Reverse()));
    }
}

