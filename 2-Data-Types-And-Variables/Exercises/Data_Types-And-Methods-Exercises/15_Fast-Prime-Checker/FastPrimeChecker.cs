using System;

class FastPrimeChecker
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        for (int currNum = 2; currNum <= number; currNum++)
        {
            bool isPrime = true;

            for (int i = 2; i <= Math.Sqrt(currNum); i++)
            {
                if (currNum % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            Console.WriteLine($"{currNum} -> {isPrime}");
        }
    }
}

