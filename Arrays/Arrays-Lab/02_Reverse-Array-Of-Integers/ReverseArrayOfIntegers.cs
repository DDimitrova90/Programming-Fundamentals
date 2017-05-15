using System;
using System.Linq;

class ReverseArrayOfIntegers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        numbers = numbers.Reverse().ToArray();
        // another option
        //Array.Reverse(numbers);

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }

        // another option
        //for (int i = numbers.Length - 1; i >= 0; i--)
        //{
        //    Console.Write(numbers[i] + " ");
        //}
    }
}

