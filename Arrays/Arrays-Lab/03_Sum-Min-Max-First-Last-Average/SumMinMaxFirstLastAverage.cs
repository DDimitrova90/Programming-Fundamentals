using System;

class SumMinMaxFirstLastAverage
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Sum = {0}", SumValues(numbers));
        Console.WriteLine("Min = {0}", FindMinValue(numbers));
        Console.WriteLine("Max = {0}", FindMaxValue(numbers));
        Console.WriteLine("First = {0}", FindFirstValue(numbers));
        Console.WriteLine("Last = {0}", FindLastValue(numbers));
        Console.WriteLine("Average = {0}", FindAverageValue(numbers));
    }

    static double FindAverageValue(int[] numbers)
    {
        double average = (double)SumValues(numbers) / numbers.Length;
        return average;
    }

    static int FindLastValue(int[] numbers)
    {
        return numbers[numbers.Length - 1];
    }

    static int FindFirstValue(int[] numbers)
    {
        return numbers[0];
    }

    static int FindMaxValue(int[] numbers)
    {
        int max = int.MinValue;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        return max;
    }

    static int FindMinValue(int[] numbers)
    {
        int min = int.MaxValue;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }

        return min;
    }

    static int SumValues(int[] numbers)
    {
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        return sum;
    }
}

