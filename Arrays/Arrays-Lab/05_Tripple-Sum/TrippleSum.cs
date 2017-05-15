using System;
using System.Linq;

class TrippleSum
{
    static void Main()
    {
        int[] arrayOfInt = Console.ReadLine()
            .Split(' ')
            .Select(number => int.Parse(number))
            .ToArray();

        bool contains = ContainsTripleSum(arrayOfInt);

        if (!contains)
        {
            Console.WriteLine("No");
        }
    }

    static bool ContainsTripleSum(int[] arrayOfInt)
    {
        bool containsTripleSum = false;

        for (int i = 0; i < arrayOfInt.Length; i++)
        {
            for (int j = i + 1; j < arrayOfInt.Length; j++)
            {
                int sum = arrayOfInt[i] + arrayOfInt[j];

                if (arrayOfInt.Contains(sum))
                {
                    Console.WriteLine("{0} + {1} == {2}", arrayOfInt[i], arrayOfInt[j], sum);
                    containsTripleSum = true;
                }
            }
        }

        return containsTripleSum;
    }
}
