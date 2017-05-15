using System;

class DifferentIntegersSize2
{
    static void Main()
    {
        string input = Console.ReadLine();
        bool isTooLong = true;

        try
        {
            sbyte num = sbyte.Parse(input);
            Console.WriteLine($"{input} can fit in:");
            Console.WriteLine("* sbyte");
            isTooLong = false;
        }
        catch (OverflowException)
        {
        }

        try
        {
            byte num = byte.Parse(input);

            if (isTooLong)
            {
                Console.WriteLine($"{input} can fit in:");
            }

            Console.WriteLine("* byte");
            isTooLong = false;
        }
        catch (OverflowException)
        {
        }

        try
        {
            short num = short.Parse(input);

            if (isTooLong)
            {
                Console.WriteLine($"{input} can fit in:");
            }

            Console.WriteLine("* short");
            isTooLong = false;
        }
        catch (OverflowException)
        {
        }

        try
        {
            ushort num = ushort.Parse(input);

            if (isTooLong)
            {
                Console.WriteLine($"{input} can fit in:");
            }

            Console.WriteLine("* ushort");
            isTooLong = false;
        }
        catch (OverflowException)
        {
        }

        try
        {
            int num = int.Parse(input);

            if (isTooLong)
            {
                Console.WriteLine($"{input} can fit in:");
            }

            Console.WriteLine("* int");
            isTooLong = false;
        }
        catch (OverflowException)
        {
        }

        try
        {          
            uint num = uint.Parse(input);

            if (isTooLong)
            {
                Console.WriteLine($"{input} can fit in:");
            }

            Console.WriteLine("* uint");
            isTooLong = false;
        }
        catch (OverflowException)
        {
        }

        try
        {          
            long num = long.Parse(input);

            if (isTooLong)
            {
                Console.WriteLine($"{input} can fit in:");
            }

            Console.WriteLine("* long");
        }
        catch (OverflowException)
        {
            Console.WriteLine($"{input} can't fit in any type");
        }
    }
}

