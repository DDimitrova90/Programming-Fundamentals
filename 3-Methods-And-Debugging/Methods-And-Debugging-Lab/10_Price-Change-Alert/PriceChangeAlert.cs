using System;

class PriceChangeAlert
{
    static void Main()
    {
        int pricesNum = int.Parse(Console.ReadLine());
        double threshold = double.Parse(Console.ReadLine());

        double lastPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < pricesNum - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());

            double priceDiff = GetsPriceDifference(lastPrice, currentPrice);
            bool isSignificantDiff = ComparePriceDiffAndThreshold(priceDiff, threshold);

            string message = GetTheTypeOfPriceChange(currentPrice, lastPrice, priceDiff, isSignificantDiff);
            Console.WriteLine(message);

            lastPrice = currentPrice;
        }
    }

    static string GetTheTypeOfPriceChange(double currentPrice, double lastPrice, double priceDiff, bool isSignificantDiff)
    {
        string message = string.Empty;

        if (priceDiff == 0)
        {
            message = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!isSignificantDiff)
        {
            message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, priceDiff * 100);
        }
        else if (isSignificantDiff && (priceDiff > 0))
        {
            message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, priceDiff * 100);
        }
        else if (isSignificantDiff && (priceDiff < 0))
        {
            message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, priceDiff * 100);
        }
            
        return message;
    }

    static bool ComparePriceDiffAndThreshold(double threshold, double priceDiff)
    {
        if (Math.Abs(threshold) >= priceDiff)
        {
            return true;
        }
        return false;
    }

    static double GetsPriceDifference(double lastPrice, double currentPrice)
    {
        double result = (currentPrice / lastPrice) - 1;
        return result;
    }
}
