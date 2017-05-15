using System;
using System.Collections.Generic;
using System.Linq;

class BombNumbers
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();
        int[] parameters = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
  
        int bombNum = parameters[0];
        int bombPower = parameters[1];        

        for (int i = 0; i < numbers.Count; i++)
        {
            if (bombNum == numbers[i])
            {
                int left = Math.Max(0, i - bombPower);
                int right = Math.Min(i + bombPower, numbers.Count - 1);
                int length = right - left + 1;

                numbers.RemoveRange(left, length);

                i = 0;               
            }
        }

        Console.WriteLine(numbers.Sum());
    }
}
