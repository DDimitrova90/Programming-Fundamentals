using System;

class EnglishNameOfTheLastDigit
{
    static void Main()
    {
        string number = Console.ReadLine();

        Console.WriteLine(LastDigitName(number));
    }

    static string LastDigitName(string number)
    {
        char lastDigit =number[number.Length - 1];

        switch(lastDigit)
        {
            case '1':
                return "one";
            case '2':
                return "two";
            case '3':
                return "three";
            case '4':
                return "four";
            case '5':
                return "five";
            case '6':
                return "six";
            case '7':
                return "seven";
            case '8':
                return "eight";
            case '9':
                return "nine";
            default:
                return "zero";
        }
    }
}

