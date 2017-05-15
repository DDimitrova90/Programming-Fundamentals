using System;

class NumbersInReversedOrder
{
    static void Main()
    {
        string number = Console.ReadLine();

        Console.WriteLine(PrintsDigitsInReversedOrder(number));
    }

    static string PrintsDigitsInReversedOrder(string number)
    {
        string result = string.Empty;

        for (int i = number.Length - 1; i >= 0; i--)
        {
            result += "" + number[i];
        }

        return result;
    }
}

