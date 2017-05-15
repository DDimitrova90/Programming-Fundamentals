using System;

class LargestCommonEnd
{
    static void Main()
    {
        string[] firstArray = Console.ReadLine().Split(' ');
        string[] secondArray = Console.ReadLine().Split(' ');

        int shorter = Math.Min(firstArray.Length, secondArray.Length);
        int counterLeft = 0;
        int counterRight = 0;

        for (int i = 0; i < shorter; i++)
        {
            if (firstArray[i] == secondArray[i])
            {
                counterLeft++;
            }
        }

        for (int i = 0; i < shorter; i++)
        {
            if (firstArray[firstArray.Length - 1 - i] == secondArray[secondArray.Length - 1 - i])
            {
                counterRight++;
            }
        }

        Console.WriteLine(Math.Max(counterLeft, counterRight));
    }
}

