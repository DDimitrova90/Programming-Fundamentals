using System;

class VariableInHexFormat
{
    static void Main()
    {
        string var = Console.ReadLine();
       
        int num = Convert.ToInt32(var, 16);  
  
        Console.WriteLine(num);
    }
}

