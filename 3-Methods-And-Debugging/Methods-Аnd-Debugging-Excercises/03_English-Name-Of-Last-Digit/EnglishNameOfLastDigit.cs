using System;

class EnglishNameOfLastDigit
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());

        string lastDigitName = GetTheNameOfLastDigit(number);

        Console.WriteLine(lastDigitName);
    }

    static string GetTheNameOfLastDigit(long number)
    {
        long lastDigit = Math.Abs(number) % 10;  // can be negative

        switch (lastDigit)
        {
            case 1:
                return "one";
            case 2:
                return "two";
            case 3:
                return "three";
            case 4:
                return "four";
            case 5:
                return "five";
            case 6:
                return "six";
            case 7:
                return "seven";
            case 8:
                return "eight";
            case 9:
                return "nine";
            default:
                return "zero";
        }
    }
}

