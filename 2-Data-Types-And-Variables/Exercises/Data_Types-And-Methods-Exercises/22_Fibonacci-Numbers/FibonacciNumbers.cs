using System;

class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(Fib(n));
    }

    static int Fib(int n)
    {
        int fib1 = 1;
        int fib2 = 1;
        int nebFib = 0;

        if (n < 2)
        {
            return 1;
        }

        for (int i = 2; i <= n; i++)
        {
            nebFib = fib1 + fib2;
            fib1 = fib2;
            fib2 = nebFib;      
        }

        return nebFib;
    }
}

