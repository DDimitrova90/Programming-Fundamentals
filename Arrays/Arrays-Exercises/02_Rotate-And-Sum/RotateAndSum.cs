using System;
using System.Linq;

class RotateAndSum
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
        int rotations = int.Parse(Console.ReadLine());

        int[] sumOfRotations = new int[numbers.Length];

        for (int currRotation = 0; currRotation < rotations; currRotation++)
        {
            int lastElement = numbers[numbers.Length - 1];

            // or this way, but without for loop
            //Array.Copy(numbers, 0, numbers, 1, numbers.Length - 1);

            for (int currElement = numbers.Length - 1; currElement > 0; currElement--)
            {
                numbers[currElement] = numbers[currElement - 1];
            }

            numbers[0] = lastElement;

            for (int currElement = 0; currElement < numbers.Length; currElement++)
            {
                sumOfRotations[currElement] += numbers[currElement];
            }
        }

        Console.WriteLine(string.Join(" ", sumOfRotations));
    }
}

