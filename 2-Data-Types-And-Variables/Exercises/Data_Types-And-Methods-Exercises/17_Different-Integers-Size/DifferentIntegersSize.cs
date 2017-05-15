using System;

class DifferentIntegersSize
{
    static void Main()
    {
        string num = Console.ReadLine();

        sbyte primitive1;
        bool sbyteResult = sbyte.TryParse(num, out primitive1);

        byte primitive2;
        bool byteResult = byte.TryParse(num, out primitive2);

        short primitive3;
        bool shortResult = short.TryParse(num, out primitive3);

        ushort primitive4;
        bool ushortResult = ushort.TryParse(num, out primitive4);

        int primitive5;
        bool intResult = int.TryParse(num, out primitive5);

        uint primitive6;
        bool uintResult = uint.TryParse(num, out primitive6);

        long primitive7;
        bool longResult = long.TryParse(num, out primitive7);

        if (!sbyteResult 
            && !byteResult 
            && !shortResult 
            && !ushortResult 
            && !intResult 
            && !uintResult 
            && !longResult)
        {
            Console.WriteLine($"{num} can't fit in any type");
        }
        else
        {
            Console.WriteLine($"{num} can fit in:");

            if (sbyteResult)
            {
                Console.WriteLine("* sbyte");
            }
            if (byteResult)
            {
                Console.WriteLine("* byte");
            }
            if (shortResult)
            {
                Console.WriteLine("* short");
            }
            if (ushortResult)
            {
                Console.WriteLine("* ushort");
            }
            if (intResult)
            {
                Console.WriteLine("* int");
            }
            if (uintResult)
            {
                Console.WriteLine("* uint");
            }
            if (longResult)
            {
                Console.WriteLine("* long");
            }
        }
    }
}
