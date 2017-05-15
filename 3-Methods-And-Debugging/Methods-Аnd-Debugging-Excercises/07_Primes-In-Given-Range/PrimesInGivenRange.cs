using System;
using System.Collections.Generic;

class PrimesInGivenRange
{
    static void Main()
    {
        int startNum = int.Parse(Console.ReadLine());
        int endNum = int.Parse(Console.ReadLine());

        List<int> result = FindPrimesInRange(startNum, endNum);
        Console.WriteLine(string.Join(", ", result));
    }

    static List<int> FindPrimesInRange(int startNum, int endNum)
    {
        List<int> primeNums = new List<int>();
        bool isPrime = true;

        for (int i = startNum; i <= endNum; i++)
        {
            if (i < 2)
            {
                isPrime = false;
            }
            else
            {
                isPrime = true;

                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                    }
                }
            }

            if (isPrime)
            {
                primeNums.Add(i);
            }
        }

        return primeNums;
    }
}

