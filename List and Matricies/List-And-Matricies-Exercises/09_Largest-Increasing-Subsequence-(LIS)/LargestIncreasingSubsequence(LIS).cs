using System;
using System.Linq;                 // https://youtu.be/SZByPn0deMY

class LargestIncreasingSubsequence
{
    static void Main()
    {
        int[] nums = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        if (nums.Length == 1)
        {
            Console.WriteLine(nums[0]);
            return;
        }

        PrintLIS(nums);
    }

    //define the key method to print longest increasing subsequnece
    static void PrintLIS(int[] nums)
    {
        string[] paths = new string[nums.Length];
        int[] sizes = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            sizes[i] = 1;
            paths[i] = nums[i] + " ";
        }

        int maxLength = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (nums[i] > nums[j] && sizes[i] < sizes[j] + 1)
                {
                    sizes[i] = sizes[j] + 1;
                    paths[i] = paths[j] + nums[i] + " ";

                    if (maxLength < sizes[i])
                    {
                        maxLength = sizes[i];
                    }
                }
            }
        }

        for (int i = 1; i < nums.Length; i++)
        { 
            if (sizes[i] == maxLength)
            {
                Console.WriteLine(paths[i]);
                break;
            }
        }
    }
}


