using System;

class BooleanVariable
{
    static void Main()
    {
        string variable = Console.ReadLine();
        bool isItTrue = Convert.ToBoolean(variable);

        if (isItTrue)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

