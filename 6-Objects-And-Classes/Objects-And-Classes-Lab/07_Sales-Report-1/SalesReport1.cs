using System;
using System.Collections.Generic;
using System.Linq;

public class SalesReport
{
    public static void Main()
    {
        Sale[] sales = ReadSales();
        
        List<string> towns = sales
                                  .Select(x => x.Town)
                                  .Distinct()
                                  .OrderBy(t => t)
                                  .ToList();

        foreach (string town in towns)
        {
            decimal salesByTown = sales
                                       .Where(x => town == x.Town)
                                       .Select(s => s.Price * s.Quantity)
                                       .Sum();

            Console.WriteLine("{0} -> {1:F2}", town, salesByTown);
        }
    
    }

    static Sale ReadSale()
    {
        Sale sale = new Sale();

        string[] saleInfo = Console.ReadLine().Split(' ');
        sale.Town = saleInfo[0];
        sale.Product = saleInfo[1];
        sale.Price = decimal.Parse(saleInfo[2]);
        sale.Quantity = decimal.Parse(saleInfo[3]);

        return sale;
    }

    static Sale[] ReadSales()
    {
        int n = int.Parse(Console.ReadLine());
        Sale[] sales = new Sale[n];

        for (int i = 0; i < n; i++)
        {
            sales[i] = ReadSale();
        }

        return sales;
    }
}

public class Sale
{
    public string Town { get; set; }
    public string Product { get; set; }
    public decimal Price { get; set; }
    public decimal Quantity { get; set; }
}

