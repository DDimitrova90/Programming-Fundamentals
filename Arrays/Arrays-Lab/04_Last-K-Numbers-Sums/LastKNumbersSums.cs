using System;

class LastKNumbersSums
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        long[] sequence = new long[n];
        sequence[0] = 1;

        SumLastKElements(sequence, k);

        PrintSequence(sequence);
    }

    static void SumLastKElements(long[] sequence, int k)
    {
        for (int i = 1; i < sequence.Length; i++) //from i = 1, because i[0] = 1
        {
            long nextElement = 0;
            int startElement = Math.Max(0, i - k);
            int endElement = i - 1;

            for (int j = startElement; j <= endElement; j++)
            {
                nextElement += sequence[j];
            }

            sequence[i] = nextElement;

            // or
            //long sum = 0;
            //for (int prev = i - k; prev <= i - 1; prev++)
            //    if (prev >= 0)
            //        sum += nums[prev];
            //nums[i] = sum;
        }
    }

    static void PrintSequence(long[] sequence)
    {
        Console.WriteLine(string.Join(" ", sequence));
    }
}

