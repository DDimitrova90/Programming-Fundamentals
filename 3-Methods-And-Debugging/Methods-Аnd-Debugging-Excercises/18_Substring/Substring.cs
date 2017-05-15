using System;

public class Substring_broken
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int jump = int.Parse(Console.ReadLine());

        bool hasMatch = false;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == 'p')
            {
                hasMatch = true;

                int endIndex = jump + 1;

                string matchedString = string.Empty;

                if (i + endIndex <= text.Length) 
                {
                    // "ednIndex" is the length of the new string and must contains 4 letters        
                    matchedString = text.Substring(i, endIndex);
                }                                  
                else                               
                {
                    matchedString = text.Substring(i);
                }

                Console.WriteLine(matchedString);
                i += jump;
            }
        }

        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}
