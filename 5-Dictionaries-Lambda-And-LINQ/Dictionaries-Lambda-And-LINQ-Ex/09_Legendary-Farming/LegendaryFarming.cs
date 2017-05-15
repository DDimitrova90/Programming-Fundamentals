using System;
using System.Collections.Generic;
using System.Linq;

public class LegendaryFarming
{
    public static void Main()
    {
        Dictionary<string, int> keyItems = new Dictionary<string, int>();
        Dictionary<string, int> junkItems = new Dictionary<string, int>();

        keyItems["fragments"] = 0;
        keyItems["motes"] = 0;
        keyItems["shards"] = 0;

        while (true)
        {
            string[] input = Console.ReadLine().ToLower().Split(' ');
            string obtainedItem = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 != 0)
                {
                    if (input[i] == "shards" || input[i] == "fragments" || input[i] == "motes")
                    {
                        keyItems[input[i]] += int.Parse(input[i - 1]);

                        if (keyItems[input[i]] >= 250)
                        {
                            if (input[i] == "shards")
                            {
                                obtainedItem = "Shadowmourne";
                            }
                            else if (input[i] == "fragments")
                            {
                                obtainedItem = "Valanyr";
                            }
                            else if (input[i] == "motes")
                            {
                                obtainedItem = "Dragonwrath";
                            }

                            keyItems[input[i]] -= 250;
                            Console.WriteLine($"{obtainedItem} obtained!");

                            foreach (KeyValuePair<string, int> pair in keyItems.OrderByDescending(x => x.Value))
                            {
                                Console.WriteLine($"{pair.Key}: {pair.Value}");
                            }
                            foreach (KeyValuePair<string, int> pair in junkItems.OrderBy(x => x.Key))
                            {
                                Console.WriteLine($"{pair.Key}: {pair.Value}");
                            }

                            return;
                        }
                    }
                    else
                    {
                        if (!junkItems.ContainsKey(input[i]))
                        {
                            junkItems[input[i]] = int.Parse(input[i - 1]);
                        }
                        else
                        {
                            junkItems[input[i]] += int.Parse(input[i - 1]);
                        }
                    }
                }
            }
        }
    }
}

