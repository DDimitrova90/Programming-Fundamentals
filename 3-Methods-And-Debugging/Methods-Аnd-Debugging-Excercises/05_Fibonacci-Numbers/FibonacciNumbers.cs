using System;

class FibonacciNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int result = Fib(number);

        Console.WriteLine(result);
    }

    static int Fib(int number)
    {
        int fibNum0 = 1;
        int fibNum1 = 1;
        int currFib = 0;

        if (number < 2)
        {
            currFib = 1;
        }

        for (int i = 2; i <= number; i++)
        {
            currFib = fibNum0 + fibNum1;
            fibNum0 = fibNum1;
            fibNum1 = currFib;
        }

        return currFib;
    }
}

