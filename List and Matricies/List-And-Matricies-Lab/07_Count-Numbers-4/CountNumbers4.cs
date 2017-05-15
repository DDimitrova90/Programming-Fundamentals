using System;
using System.Collections.Generic;
using System.Linq;

class CountNumbers4
{
    static void Main()
    {
        List<int> nums = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        nums.Sort();
        int pos = 0;

        while (pos < nums.Count)
        {
            int num = nums[pos];
            int count = 1;

            while (pos + count < nums.Count && nums[pos + count] == num)
            {
                count++;
                pos = pos + count;
            }

            Console.WriteLine($"{num} -> {count}");
        }
    }
}

