using System;
using System.Collections.Generic;
using System.Linq;

public class SumBigNumbers
{
    public static void Main()
    {
        string firstNum = Console.ReadLine();
        string secondNum = Console.ReadLine();

        string sum = "";

        if (firstNum.Length <= secondNum.Length)
        {
            sum = SumNumbers(firstNum, secondNum);
        }
        else
        {
            sum = SumNumbers(secondNum, firstNum);
        }

        Console.WriteLine(sum);
    }

    static string SumNumbers(string firstNum, string secondNum)
    {
        List<string> sum = new List<string>();
        long digitsSum = 0;
        int j = 0;

        for (int i = firstNum.Length - 1; i >= 0; i--)
        {
            int digitNum1 = Convert.ToInt32(firstNum[i].ToString());
            int digitNum2 = Convert.ToInt32(secondNum[secondNum.Length - 1 - j].ToString());
            digitsSum += digitNum1 + digitNum2;
            j++;
            
            if (digitsSum <= 9)
            {
                sum.Add(digitsSum.ToString());
                digitsSum = 0;
            }
            else
            {
                sum.Add((digitsSum % 10).ToString());
                digitsSum = digitsSum / 10;
            }
        }

        for (int i = secondNum.Length - firstNum.Length - 1; i >= 0; i--)
        {
            int digit = Convert.ToInt32(secondNum[i].ToString());

            digitsSum += digit;

            if (digitsSum <= 9)
            {
                sum.Add(digitsSum.ToString());
                digitsSum = 0;
            }
            else
            {
                sum.Add((digitsSum % 10).ToString());
                digitsSum = digitsSum / 10;

                if (i == 0 && digitsSum != 0)
                {
                    sum.Add(digitsSum.ToString());
                }
            }
        }

        sum.Reverse();

        //for (int i = 0; i < sum.Count; i++)
        //{
        //    if (sum[i].Equals("0"))
        //    {
        //        sum.RemoveAt(i);
        //        i--;
        //    }
        //    else
        //    {
        //        break;
        //    }
        //}               

        string result = string.Join("", sum.SkipWhile(x => x.Equals("0")));

        return result;
    }
}

