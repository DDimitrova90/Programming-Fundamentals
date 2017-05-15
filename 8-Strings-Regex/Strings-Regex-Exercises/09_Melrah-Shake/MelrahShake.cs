using System;

public class MelrahShake
{
    public static void Main()
    {
        string str = Console.ReadLine();
        string pattern = Console.ReadLine();

        while (str.Contains(pattern))
        {
            int firstOccurance = str.IndexOf(pattern);
            int lastOccurance = str.LastIndexOf(pattern);

            if (firstOccurance != lastOccurance)
            { 
                str = str.Remove(firstOccurance, pattern.Length);
                str = str.Remove(lastOccurance - pattern.Length, pattern.Length);
                Console.WriteLine("Shaked it.");
                int index = pattern.Length / 2;
                pattern = pattern.Remove(index, 1);

                if (pattern == "")
                {
                    break;
                }
            }
            else if (firstOccurance == lastOccurance)
            {
                break;
            }
        }

        Console.WriteLine("No shake.");
        Console.WriteLine(str);
    }
}

