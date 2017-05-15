using System;
using System.Linq;

public class LettersChangeNumbers
{
    public static void Main()
    {
        string[] input = Console.ReadLine()
            .Split(new char[] { ' ', '\t' }, 
            StringSplitOptions.RemoveEmptyEntries);

        decimal result = 0;
        
        for (int i = 0; i < input.Length; i++)
        {
            string num = input[i].Substring(1, input[i].Length - 2);
            decimal number = Convert.ToDecimal(num);

            char letterBefore = input[i].ElementAt(0);
            char letterAfter = input[i].ElementAt(input[i].Length - 1);

            if (char.IsUpper(letterBefore))
            {
                int letterPos = Convert.ToInt32((letterBefore - 64).ToString());
                number = number / letterPos;
            }
            else if (char.IsLower(letterBefore))
            {
                int letterPos = Convert.ToInt32((letterBefore - 96).ToString());
                number = number * letterPos;
            }

            if (char.IsUpper(letterAfter))
            {
                int letterPos = Convert.ToInt32((letterAfter - 64).ToString());
                number = number - letterPos;
            }
            else if (char.IsLower(letterAfter))
            {
                int letterPos = Convert.ToInt32((letterAfter - 96).ToString());
                number = number + letterPos;
            }

            result += number;
        }

        Console.WriteLine("{0:F2}", result);
    }
}

