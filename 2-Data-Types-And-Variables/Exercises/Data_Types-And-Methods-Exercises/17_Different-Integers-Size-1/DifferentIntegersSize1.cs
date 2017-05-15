using System;
using System.Numerics;

class DifferentIntegersSize1
{
    static void Main()
    {
        BigInteger num = BigInteger.Parse(Console.ReadLine());

        bool isSByte = num >= sbyte.MinValue && num <= sbyte.MaxValue;
        bool isByte = num >= byte.MinValue && num <= byte.MaxValue;
        bool isShort = num >= short.MinValue && num <= short.MaxValue;
        bool isUShort = num >= ushort.MinValue && num <= ushort.MaxValue;
        bool isInt = num >= int.MinValue && num <= int.MaxValue;
        bool isUInt = num >= uint.MinValue && num <= uint.MaxValue;
        bool isLong = num >= long.MinValue && num <= long.MaxValue;

        if (isSByte || isByte || isShort || isUShort || isInt || isUInt || isLong)
        {
            Console.WriteLine($"{num} can fit in:");

            if (isSByte)
            {
                Console.WriteLine("* sbyte");
            }
            if (isByte)
            {
                Console.WriteLine("* byte");
            }
            if (isShort)
            {
                Console.WriteLine("* short");
            }
            if (isUShort)
            {
                Console.WriteLine("* ushort");
            }
            if (isInt)
            {
                Console.WriteLine("* int");
            }
            if (isUInt)
            {
                Console.WriteLine("* uint");
            }
            if (isLong)
            {
                Console.WriteLine("* long");
            }
        }
        else
        {
            Console.WriteLine($"{num} can't fit in any type");
        }
    }
}


