using System;
using System.Linq;

class EqualSums
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int[] nums = new int[numbers.Length + 1];
        Array.Copy(numbers, nums, numbers.Length);
        int leftSum = 0;
        int rightElementIndex = 0;
        bool noSuchElement = true;
        
        for (int i = 0; i < numbers.Length; i++)
        {
            int rightSum = 0;

            if (i == 0)
            {
                leftSum = 0;
            }
            else
            {
                leftSum += numbers[i - 1];
            }

            for (int j = i + 1; j < nums.Length; j++)
            {
                rightSum += nums[j];
            }

            if (leftSum == rightSum)
            {
                rightElementIndex = i;
                noSuchElement = false;
                break;
            }
        }

        if (noSuchElement)
        {
            Console.WriteLine("no");
        }
        else
        {
            Console.WriteLine(rightElementIndex);
        }
    }
}

