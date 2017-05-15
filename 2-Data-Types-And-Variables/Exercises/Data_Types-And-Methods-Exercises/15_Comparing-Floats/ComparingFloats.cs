using System;

class ComparingFloats   //We can't compare directly two numbers with decimal point
{
    static void Main()
    {
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());

        double eps = 0.000001;
        double differance = Math.Abs(num1 - num2);

        if (differance < eps)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}

