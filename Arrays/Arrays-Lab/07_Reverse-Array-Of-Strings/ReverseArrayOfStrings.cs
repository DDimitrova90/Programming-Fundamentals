using System;

class ReverseArrayOfStrings
{
    static void Main()
    {
        string[] stringArr = Console.ReadLine().Split(' ');

        // first option
        //Array.Reverse(stringArr);

        // second option 
        //stringArr = stringArr.Reverse().ToArray();

        //Console.WriteLine(string.Join(" ", stringArr));

        PrintReversedArray(stringArr);
    }

    static void PrintReversedArray(string[] stringArr)
    {
        for (int i = 0; i < stringArr.Length / 2; i++)
        {
            string temp = stringArr[i];
            stringArr[i] = stringArr[stringArr.Length - 1 - i];
            stringArr[stringArr.Length - 1 - i] = temp;
        }

        Console.WriteLine(string.Join(" ", stringArr));
    }
}

