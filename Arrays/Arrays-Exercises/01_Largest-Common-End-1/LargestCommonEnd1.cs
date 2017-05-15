using System;

class LargestCommonEnd1
{
    static void Main()
    {
        string[] firstArray = Console.ReadLine().Split(' ');
        string[] secondArray = Console.ReadLine().Split(' ');

        int shorter = Math.Min(firstArray.Length, secondArray.Length);

        int leftCounter = FindsLeftCommonEnd(shorter, firstArray, secondArray);
        int rightCounter = FindsRightCommonEnd(shorter, firstArray, secondArray);

        Console.WriteLine(Math.Max(leftCounter, rightCounter));
    }

    static int FindsRightCommonEnd(int shorter, string[] firstArray, string[] secondArray)
    {
        int counter = 0;
        Array.Reverse(firstArray);
        Array.Reverse(secondArray);

        for (int i = 0; i < shorter; i++)
        {
            if (firstArray[i] == secondArray[i])
            {
                counter++;
            }
            else
            {
                break;
            }
        }

        return counter;
    }

    static int FindsLeftCommonEnd(int shorter, string[] firstArray, string[] secondArray)
    {
        int counter = 0;

        for (int i = 0; i < shorter; i++)
        {
            if (firstArray[i] == secondArray[i])
            {
                counter++;
            }
            else
            {
                break;
            }
        }

        return counter;
    }
}

