using System;
using System.Collections.Generic;
using System.Linq;

public class AndreyAndBilliard
{
    public static void Main()
    {
        Shop gameBar = ReadShop();

        List<Customer> customers = ReadCustomers(gameBar);

        PrintCustomers(customers, gameBar);
    }

    static void PrintCustomers(List<Customer> customers, Shop gameBar)
    {
        foreach (var customer in customers)
        {
            foreach (var item in customer.Order)
            {
                foreach (var product in gameBar.Products)
                {
                    if (item.Key == product.Key)
                    {
                        customer.Bill += item.Value * product.Value;
                    }
                }
            }
        }

        List<Customer> ordered = customers
                            .OrderBy(x => x.Name)
                            .ThenBy(x => x.Bill)
                            .ToList();
        foreach (var customer in ordered)
        {
            Console.WriteLine(customer.Name);
            foreach (KeyValuePair<string, int> entry in customer.Order)
            {
                Console.WriteLine($"-- {entry.Key} - {entry.Value}");
            }

            Console.WriteLine("Bill: {0:F2}", customer.Bill);
        }

        Console.WriteLine("Total bill: {0:F2}", customers.Sum(c => c.Bill));
    }

    static List<Customer> ReadCustomers(Shop gameBar)
    {
        string customerInput = Console.ReadLine();
        List<Customer> customers = new List<Customer>();

        while (customerInput != "end of clients")
        {
            Customer customer = ReadCustomer(customerInput);

            foreach (var prod in customer.Order)
            {
                if (gameBar.Products.ContainsKey(prod.Key))
                {
                    if (customers.Any(c => c.Name == customer.Name))
                    {
                        Customer existingCustomer = customers.First(c => c.Name == customer.Name);
                        if (existingCustomer.Order.ContainsKey(prod.Key))
                        {
                            existingCustomer.Order[prod.Key] += prod.Value;
                        }
                        else
                        {
                            existingCustomer.Order[prod.Key] = prod.Value;
                        }
                    }
                    else
                    {
                        customers.Add(customer);
                    }
                }
            }

            customerInput = Console.ReadLine();
        }

        return customers;
    }

    static Customer ReadCustomer(string customerInput)
    {
        string[] customerInfo = customerInput.Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
        Dictionary<string, int> order = new Dictionary<string, int>();

        Customer customer = new Customer();
        customer.Name = customerInfo[0];

        if (!order.ContainsKey(customerInfo[1]))
        {
            order.Add(customerInfo[1], 0);
        }

        order[customerInfo[1]] = int.Parse(customerInfo[2]);
        customer.Order = order;

        return customer;
    }

    static Shop ReadShop()
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, decimal> products = new Dictionary<string, decimal>();
        Shop shop = new Shop();

        for (int i = 0; i < n; i++)
        {
            Product product = ReadProduct();
            if (!products.ContainsKey(product.Name))
            {
                products.Add(product.Name, 0);
            }

            products[product.Name] = product.Price;
        }

        shop.Name = "Game Bar";
        shop.Products = products;

        return shop;
    }

    static Product ReadProduct()
    {
        string[] productInfo = Console.ReadLine().Split('-');

        Product product = new Product();

        product.Name = productInfo[0];
        product.Price = decimal.Parse(productInfo[1]);
        return product;
    }
}

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}

public class Shop
{
    public string Name { get; set; }
    public Dictionary<string, decimal> Products { get; set; }
}

public class Customer
{
    public string Name { get; set; }
    public Dictionary<string, int> Order { get; set; }
    public decimal Bill { get; set; }
}

