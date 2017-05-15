using System;
using System.Collections.Generic;   // https://judge.softuni.bg/Contests/Practice/Index/218#3
using System.Linq;                  

public class SoftUniCoffeeSupplies
{
    public static void Main()
    {
        string[] delimiters = Console.ReadLine().Split(' ');
        string firstInput = Console.ReadLine();

        Dictionary<string, string> preferredCoffees = new Dictionary<string, string>();
        Dictionary<string, long> coffeeSupplies = new Dictionary<string, long>();
        Dictionary<string, long> coffeeOrders = new Dictionary<string, long>();

        while (firstInput != "end of info")
        {
            if (firstInput.Contains(delimiters[1]))
            {
                string[] coffeeInfo = firstInput.Split(new[] { delimiters[1] }, StringSplitOptions.RemoveEmptyEntries);

                if (!coffeeSupplies.ContainsKey(coffeeInfo[0]))
                {
                    coffeeSupplies.Add(coffeeInfo[0], 0);
                }

                coffeeSupplies[coffeeInfo[0]] += long.Parse(coffeeInfo[1]);
            }
            else if (firstInput.Contains(delimiters[0]))
            {
                string[] coffeeInfo = firstInput.Split(new[] { delimiters[0] }, StringSplitOptions.RemoveEmptyEntries);

                preferredCoffees[coffeeInfo[0]] = coffeeInfo[1];
            }

            firstInput = Console.ReadLine();
        }

        foreach (var entry in preferredCoffees)
        {
            if (!coffeeSupplies.ContainsKey(entry.Value))
            {
                Console.WriteLine($"Out of {entry.Value}");
            }
        }

        string secondInput = Console.ReadLine();

        while (secondInput != "end of week")
        {
            string[] coffeInfo = secondInput.Split(' ');

            if (!coffeeOrders.ContainsKey(coffeInfo[0]))
            {
                coffeeOrders.Add(coffeInfo[0], 0);
            }

            coffeeOrders[coffeInfo[0]] += long.Parse(coffeInfo[1]);

            secondInput = Console.ReadLine();
        }

        foreach (var order in coffeeOrders)
        {
            foreach (var member in preferredCoffees)
            {
                var currCoffee = coffeeSupplies
                    .Where(x => x.Key == member.Value)
                    .Select(x => x.Key)
                    .ToList();

                foreach (var entry in currCoffee)
                {
                    if (order.Key == member.Key)
                    {
                        coffeeSupplies[entry] -= order.Value;

                        if (coffeeSupplies[entry] <= 0)
                        {
                            Console.WriteLine($"Out of {entry}");
                        }
                    }
                }
            }
        }

        Console.WriteLine("Coffee Left:");

        foreach (var entry in coffeeSupplies.Where(x => x.Value > 0).OrderByDescending(x => x.Value))
        {
            Console.WriteLine($"{entry.Key} {entry.Value}");
        }

        Console.WriteLine("For:");

        Dictionary<string, string> leftCoffee = new Dictionary<string, string>();

        foreach (var coffee in coffeeSupplies.Where(x => x.Value > 0))
        {
            foreach (var entry in preferredCoffees.Where(x => x.Value == coffee.Key))
            {
                leftCoffee[entry.Key] = entry.Value;
            }
        }

        foreach (var memb in leftCoffee.OrderBy(x => x.Value).ThenByDescending(n => n.Key))
        {
            Console.WriteLine($"{memb.Key} {memb.Value}");
        }
    }
}

