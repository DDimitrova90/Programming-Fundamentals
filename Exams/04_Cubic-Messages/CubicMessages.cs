using System;
using System.Collections.Generic;     // https://judge.softuni.bg/Contests/Practice/Index/332#3
using System.Text.RegularExpressions;

public class CubicMessages
{
    public static void Main()
    {
        string message = Console.ReadLine();
        string pattern = @"^([0-9]+)([a-zA-Z]+)([^a-zA-Z]*)$";
        Regex regex = new Regex(pattern);
        Dictionary<string, string> messages = new Dictionary<string, string>();

        while (message != "Over!")
        {
            int length = int.Parse(Console.ReadLine());

            Match match = regex.Match(message);
            string msg = match.Groups[2].ToString();
            List<int> digits = new List<int>();

            if (msg.Length == length)
            {
                string partBefore = match.Groups[1].ToString();
                string partAfter = match.Groups[3].ToString();

                for (int i = 0; i < partBefore.Length; i++)
                {
                    if (char.IsNumber(partBefore[i]))
                    {
                        digits.Add(int.Parse(partBefore[i].ToString()));
                    }
                }

                for (int i = 0; i < partAfter.Length; i++)
                {
                    if (char.IsNumber(partAfter[i]))
                    {
                        digits.Add(int.Parse(partAfter[i].ToString()));
                    }
                }

                string verificationCode = "";

                for (int i = 0; i < digits.Count; i++)
                {
                    if (digits[i] >= 0 && digits[i] < msg.Length)
                    {
                        verificationCode += msg[digits[i]];
                    }
                    else
                    {
                        verificationCode += " ";
                    }
                }

                Console.WriteLine($"{msg} == {verificationCode}");
            }         

            message = Console.ReadLine();
        }
    }
}

