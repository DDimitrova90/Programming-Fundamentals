using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int r = int.Parse(input[1]);
        int c = int.Parse(input[2]);

        switch (input[0])
        {
            case "A": PrintMatrix(TypeA(r, c)); break;
            case "B": PrintMatrix(TypeB(r, c)); break;
            case "C": PrintMatrix(TypeC(r, c)); break;
            case "D": PrintMatrix(TypeD(r, c)); break;
            default: break;
        }
    }

    static int[,] TypeA(int r, int c)
    {
        int[,] m = new int[r, c];
        int number = 1;

        for (int i = 0; i < c; i++)
        {
            for (int j = 0; j < r; j++)
            {
                m[j, i] = number;
                number++;
            }
        }

        return m;
    }

    static int[,] TypeB(int r, int c)
    {
        int[,] m = new int[r, c];
        int number = 1;

        for (int i = 0; i < c; i++)
        {
            for (int j = 0; j < r; j++)
            {
                if (i % 2 == 0) { m[j, i] = number; number++; }
                else { m[r - 1 - j, i] = number; number++; }
            }
        }

        return m;
    }

    static int[,] TypeC(int r, int c)
    {
        int[,] m = new int[r, c];
        int number = 1;

        for (int i = r - 1; i >= 0; i--)
        {
            int startR = i;
            for (int j = 0; j < r - startR; j++)
            {
                if (j > c - 1) { break; }
                m[startR + j, j] = number; number++;
            }
        }

        for (int i = 1; i < c; i++)
        {
            int startC = i;
            for (int j = 0; j < c - startC; j++)
            {
                if (j > r - 1) { break; }
                m[j, startC + j] = number; number++;
            }
        }

        return m;
    }

    static int[,] TypeD(int r, int c)
    {
        int[,] m = new int[r, c];
        int number = 1;
        int indexR = 0;
        int indexC = 0;

        while (number <= r * c)
        {
            m[indexR, indexC] = number;
            number++; ;

            bool canGoDown = 
                (indexR + 1) < r &&
                m[indexR + 1, indexC] == 0 &&
                !((indexC - 1) >= 0 &&
                m[indexR, indexC - 1] == 0);
            if (canGoDown) { indexR++; continue; }
            bool canGoRight = (indexC + 1) < c && m[indexR, indexC + 1] == 0;
            if (canGoRight) { indexC++; continue; }
            bool canGoUp = (indexR - 1) >= 0 && m[indexR - 1, indexC] == 0;
            if (canGoUp) { indexR--; continue; }
            bool canGoLeft = (indexC - 1) >= 0 && m[indexR, indexC - 1] == 0;
            if (canGoLeft) { indexC--; continue; }
        }

        return m;
    }

    static void PrintMatrix(int[,] m)
    {
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
            {
                Console.Write($"{m[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}