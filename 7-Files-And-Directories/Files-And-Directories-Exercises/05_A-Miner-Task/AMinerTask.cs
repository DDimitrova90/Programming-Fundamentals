using System;
using System.Collections.Generic;
using System.IO;

public class AMinerTask
{
    public static void Main()
    {
        string resource = Console.ReadLine();

        Dictionary<string, int> resources = new Dictionary<string, int>();

        File.WriteAllText("Input.txt", "");
        File.WriteAllText("Output.txt", "");
        File.AppendAllText("Input.txt", resource + "\r\n");

        while (resource != "stop")
        {
            string quantityStr = Console.ReadLine();
            int quantity = int.Parse(quantityStr);

            File.AppendAllText("Input.txt", quantityStr + "\r\n");

            if (!resources.ContainsKey(resource))
            {
                resources.Add(resource, quantity);
            }
            else
            {
                resources[resource] += quantity;
            }

            resource = Console.ReadLine();
            File.AppendAllText("Input.txt", resource + "\r\n");
        }

        foreach (var pair in resources)
        {
            File.AppendAllText("Output.txt", $"{pair.Key} -> {pair.Value}{Environment.NewLine}");
            Console.WriteLine($"{pair.Key} -> {pair.Value}");
        }
    }
}

