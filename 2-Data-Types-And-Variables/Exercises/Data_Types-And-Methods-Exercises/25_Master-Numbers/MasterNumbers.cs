using System;

class MasterNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if (SumOfDigits(i) && ContainEvenDigit(i) && IsPalidrome(i))
            {
                Console.WriteLine(i);
            }
        }
    }

    static bool SumOfDigits(int number)
    {
        int sumOfDigits = 0;

        while (number > 0)
        {
            int lastDigit = number % 10;
            sumOfDigits += lastDigit;
            number = number / 10;
        }

        if (sumOfDigits % 7 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    static bool ContainEvenDigit(int number)
    {
        while (number > 0)
        {
            int lastDigit = number % 10;
            number = number / 10;

            if (lastDigit % 2 == 0)
            {
                return true;
            }
        }

        return false;
    }

    static bool IsPalidrome(int number)
    {
        string sNum = number.ToString();
        for (int i = 0; i < sNum.Length; i++)
        {
            if (sNum[i] != sNum[sNum.Length - 1 - i])
            {
                return false;
            } 
        }

        return true;
    }
}

