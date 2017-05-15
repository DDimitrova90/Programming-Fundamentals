using System;
using System.Collections.Generic;

public class SalesReport
{
    public static void Main()
    {
        Sale[] sales = ReadSales();
        SortedDictionary<string, decimal> salesByTown = GetSalesByTown(sales);
        PrintSales(salesByTown);
    }

    static void PrintSales(SortedDictionary<string, decimal> salesByTown)
    {
        foreach (var pair in salesByTown)
        {
            Console.WriteLine("{0} -> {1:F2}", pair.Key, pair.Value);
        }
    }

    static SortedDictionary<string, decimal> GetSalesByTown(Sale[] sales)
    {
        SortedDictionary<string, decimal> salesByTown = new SortedDictionary<string, decimal>();

        foreach (var sale in sales)
        {
            if (!salesByTown.ContainsKey(sale.Town))
            {
                salesByTown.Add(sale.Town, 0);
            }

            salesByTown[sale.Town] += sale.Price * sale.Quantity;
        }

        return salesByTown;
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

