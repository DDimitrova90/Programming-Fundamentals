using System;

class PrimeNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i <= n; i++)
        {
            if (SieveOfEratosthenes(n)[i] == true)
            {
                Console.Write(i + " ");
            }
        }
    }

    static bool[] SieveOfEratosthenes(int n)
    {
        bool[] isPrime = new bool[n + 1];

        for (int i = 2; i <= n; i++)
        {
            isPrime[i] = true;
        }

        for (int i = 2; i <= n; i++)
        {
            if (isPrime[i])
            {
                for (int j = 2 * i; j <= n; j += i)
                {
                    isPrime[j] = false;
                }
            }
        }

        return isPrime;
    }
}

