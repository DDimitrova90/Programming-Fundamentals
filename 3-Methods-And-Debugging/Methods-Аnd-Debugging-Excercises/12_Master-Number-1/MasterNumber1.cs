using System;

public class MasterNumber1
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        for (int currNum = 1; currNum <= number; currNum++)
        {
            bool isPalindrome = IsPalindrome(currNum);
            int digitsSum = SumOfDigits(currNum);
            bool containsEvenDigit = ContainsEvenDigit(currNum);

            if (isPalindrome && digitsSum % 7 == 0 && containsEvenDigit)
            {
                Console.WriteLine(currNum);
            }
        }
    }

    static bool IsPalindrome(int currNum)
    {
        int num = currNum;
        int reversedNum = 0;
        bool isPalindrome = false;

        while (num > 0)
        {
            int digit = num % 10;
            reversedNum = reversedNum * 10 + digit;
            num = num / 10;        
        }

        if (currNum == reversedNum)
        {
            isPalindrome = true;
        }

        return isPalindrome;
    }

    static int SumOfDigits(int currNum)
    {
        int num = currNum;
        int digitsSum = 0;

        while (num > 0)
        {
            digitsSum += num % 10;
            num = num / 10;
        }

        return digitsSum;
    }

    static bool ContainsEvenDigit(int currNum)
    {
        int num = currNum;
        bool containsEvenDigit = false;

        while (num > 0)
        {
            int digit = num % 10;
            num = num / 10;

            if (digit % 2 == 0)
            {
                containsEvenDigit = true;
                break;
            }
        }

        return containsEvenDigit;
    }
}

