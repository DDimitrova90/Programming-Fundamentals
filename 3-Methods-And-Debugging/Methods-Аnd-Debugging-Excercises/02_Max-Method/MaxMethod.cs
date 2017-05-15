using System;

class MaxMethod
{
    static void Main()
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        int thirdNum = int.Parse(Console.ReadLine());

        int maxNum = GetMaxNum(firstNum, secondNum);
        int result = Math.Max(thirdNum, maxNum);

        Console.WriteLine(result);
    }

    static int GetMaxNum(int firstNum, int secondNum)
    {
        return Math.Max(firstNum, secondNum);   
    }
}

