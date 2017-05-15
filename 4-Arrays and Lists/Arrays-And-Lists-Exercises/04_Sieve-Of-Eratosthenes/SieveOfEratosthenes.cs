using System;

public class SieveOfEratosthenes
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        bool[] isPrime = EratosthenesSieve(n);

        for (int i = 0; i <= n; i++)
        {
            if (isPrime[i])
            {
                Console.Write(i + " ");
            }
        }
    }

    static bool[] EratosthenesSieve(int n)
    {
        bool[] isPrime = new bool[n + 1];
        
        for (int i = 0; i <= n; i++)
        {
            if (i < 2)
            {
                isPrime[i] = false;
            }
            else
            {
                isPrime[i] = true;
            } 
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

