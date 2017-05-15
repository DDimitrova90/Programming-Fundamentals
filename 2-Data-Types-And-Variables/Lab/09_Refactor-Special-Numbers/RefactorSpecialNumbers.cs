using System;

class RefactorSpecialNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine()); 
        
        for (int i = 1; i <= number; i++)
        {
            int currentNumber = i;
            int digitsSum = 0;

            while (currentNumber > 0)
            {
                digitsSum += currentNumber % 10;
                currentNumber = currentNumber / 10;
            }

            bool isSpecialNum = (digitsSum == 5) || (digitsSum == 7) || (digitsSum == 11);
            Console.WriteLine($"{i} -> {isSpecialNum}");
        }
    }
}

