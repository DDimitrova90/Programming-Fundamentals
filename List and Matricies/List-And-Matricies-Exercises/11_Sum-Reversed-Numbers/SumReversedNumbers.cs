using System;
using System.Collections.Generic;

class SumReversedNumbers
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split(' ');

        List<string> result = new List<string>();

        for (int i = 0; i < numbers.Length; i++)
        {
            char[] reversedNum = numbers[i].ToCharArray();
            Array.Reverse(reversedNum);
            string num = string.Empty;

            for (int j = 0; j < reversedNum.Length; j++)
            {
                num += "" + reversedNum[j];
            }

            result.Add(num);
        }

        int sum = 0;

        for (int i = 0; i < result.Count; i++)
        {
            sum += int.Parse(result[i]);
        }

        Console.WriteLine(sum);
    }
}

