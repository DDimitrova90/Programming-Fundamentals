using System;

public class MasterNumber
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        for (int currNum = 1; currNum <= number; currNum++)
        {
            int num = currNum;
            int reversedNum = 0;
            int digitsSum = 0;
            bool holdsEvenDigit = false;

            while (num > 0)
            {
                int digit = num % 10;
                digitsSum += digit;
                reversedNum = (reversedNum * 10) + digit;
                num = num / 10;

                if (digit % 2 == 0)
                {
                    holdsEvenDigit = true;
                }
            }

            if ((currNum == reversedNum) && (digitsSum % 7 == 0) && holdsEvenDigit)
            {
                Console.WriteLine(currNum);
            }
        }
    }
}

