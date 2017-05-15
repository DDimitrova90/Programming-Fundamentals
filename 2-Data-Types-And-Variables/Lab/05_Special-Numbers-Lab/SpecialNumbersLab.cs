using System;

class SpecialNumbersLab
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            int sum = 0;
            Console.Write($"{i} -> ");
            int currNum = i;

            while (currNum > 0)
            {
                sum += currNum % 10;
                currNum = currNum / 10;
            }

            if (sum == 5 || sum == 7 || sum == 11)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}

