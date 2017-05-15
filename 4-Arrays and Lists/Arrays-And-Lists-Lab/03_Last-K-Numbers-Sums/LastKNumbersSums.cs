using System;

public class LastKNumbersSums
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        long[] numbers = new long[n];
        numbers[0] = 1;

        for (int i = 1; i < numbers.Length; i++)
        {
            int startElement = Math.Max(0, i - k);
            int endElement = i - 1;
            long nextElement = 0;

            //startElement = i - k;   
            //if (startElement < 0)
            //{
            //    startElement = 0;
            //}

            for (int j = startElement; j <= endElement; j++)
            {
                nextElement += numbers[j];
            }

            numbers[i] = nextElement;
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}

