using System;

class IntegerToHexAndBinary
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string hexNum = Convert.ToString(n, 16).ToUpper();
        string binaryNum = Convert.ToString(n, 2);

        Console.WriteLine(hexNum);
        Console.WriteLine(binaryNum);
    }
}

