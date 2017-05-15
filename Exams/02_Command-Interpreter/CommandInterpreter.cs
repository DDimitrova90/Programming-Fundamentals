using System;      // https://judge.softuni.bg/Contests/Practice/Index/331#1

public class CommandInterpreter
{
    public static void Main()
    {
        string[] strArr = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string input = Console.ReadLine();

        while (input != "end")
        {
            string[] commandInfo = input.Split(' ');
            string command = commandInfo[0];

            if (command == "reverse")
            {
                ReverseArrayElements(strArr, commandInfo);
            }
            else if (command == "sort")
            {
                SortArrayElements(strArr, commandInfo);
            }
            else if (command == "rollLeft")
            {
                strArr = RollLeftArray(strArr, commandInfo);
            }
            else if (command == "rollRight")
            {
                strArr = RollRightArray(strArr, commandInfo);
            }

            input = Console.ReadLine();
        }

        Console.WriteLine("[" + string.Join(", ", strArr) + "]");
    }

    static string[] RollRightArray(string[] strArr, string[] commandInfo)
    {
        int count = int.Parse(commandInfo[1]);

        if (count < 0 || count > int.MaxValue)
        {
            Console.WriteLine("Invalid input parameters.");
        }
        else
        {
            count = count % strArr.Length;  //VAAAJNOOOO!!!!!

            for (int currCount = 0; currCount < count; currCount++)
            {
                string[] temp = new string[strArr.Length];

                for (int i = 0; i < strArr.Length - 1; i++)
                {
                    temp[i + 1] = strArr[i];
                }

                temp[0] = strArr[strArr.Length - 1];
                strArr = temp;
            }
        }

        return strArr;
    }

    static string[] RollLeftArray(string[] strArr, string[] commandInfo)
    {
        int count = int.Parse(commandInfo[1]);

        if (count < 0 || count > int.MaxValue)
        {
            Console.WriteLine("Invalid input parameters.");
        }
        else
        {
            count = count % strArr.Length;  //VAAAJNOOOO!!!!!

            for (int currCount = 0; currCount < count; currCount++)
            {
                string[] temp = new string[strArr.Length];

                for (int i = 1; i < strArr.Length; i++)
                {
                    temp[i - 1] = strArr[i];
                }

                temp[strArr.Length - 1] = strArr[0];
                strArr = temp;
            }  
        }

        return strArr;
    }

    static void SortArrayElements(string[] strArr, string[] commandInfo)
    {
        int start = int.Parse(commandInfo[2]);
        int count = int.Parse(commandInfo[4]);

        if (start < 0 || start >= strArr.Length || count < 0 || start + count > strArr.Length)
        {
            Console.WriteLine("Invalid input parameters.");
        }
        else
        {
            Array.Sort(strArr, start, count);
        }
    }

    static void ReverseArrayElements(string[] strArr, string[] commandInfo)
    {
        int start = int.Parse(commandInfo[2]);
        int count = int.Parse(commandInfo[4]);

        if (start < 0 || start >= strArr.Length || count < 0 || start + count > strArr.Length)
        {
            Console.WriteLine("Invalid input parameters.");
        }
        else
        {
            Array.Reverse(strArr, start, count);
        }
    }
}

