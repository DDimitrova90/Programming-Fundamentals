using System;
using System.Collections.Generic;
using System.Linq;

public class MultiplyBigNumber
{
    public static void Main()
    {
        string firstNum = Console.ReadLine();
        int secondNum = int.Parse(Console.ReadLine());

        if (secondNum == 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            string product = MultiplyNumbers(firstNum, secondNum);
            Console.WriteLine(product);
        }
    }

    private static string MultiplyNumbers(string firstNum, int secondNum)
    {
        List<string> product = new List<string>();
        int digitsProduct = 0;

        for (int i = firstNum.Length - 1; i >= 0; i--)
        {
            int digit = Convert.ToInt32(firstNum[i].ToString());
            digitsProduct += digit * secondNum;

            if (digitsProduct <= 9)
            {
                product.Add(digitsProduct.ToString());
                digitsProduct = 0;
            }
            else
            {
                product.Add((digitsProduct % 10).ToString());
                digitsProduct = digitsProduct / 10;

                if (i == 0)
                {
                    product.Add(digitsProduct.ToString());
                }
            }
        }

        product.Reverse();
        string result = string.Join("", product.SkipWhile(x => x.Equals("0")));
        return result;
    }
}

