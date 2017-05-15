using System;
using System.IO;

public class AdvertisementMessage
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        File.WriteAllText("Input.txt", "");
        File.WriteAllText("Output.txt", "");
        File.WriteAllText("Input.txt", n.ToString());


        string[] phrases = new string[] 
        {   "Excellent product.",
            "Such a great product.",
            "I always use that product.",
            "Best product of its category.",
            "Exceptional product.",
            "I can’t live without this product."
        };
        string[] events = new string[] 
        {
            "Now I feel good.",
            "I have succeeded with this product.",
            "Makes miracles.I am happy of the results!",
            "I cannot believe but now I feel awesome.",
            "Try it yourself, I am very satisfied.",
            "I feel great!"
        };
        string[] authors = new string[] 
        { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
        string[] cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

        Random rnd = new Random();

        for (int i = 0; i < n; i++)
        {
            string rndPhrase = phrases[rnd.Next(0, phrases.Length)];
            string rndEvent = events[rnd.Next(0, events.Length)];
            string rndAuthor = authors[rnd.Next(0, authors.Length)];
            string rndCity = cities[rnd.Next(0, cities.Length)];

            File.AppendAllText("Output.txt", $"{rndPhrase} {rndEvent} {rndAuthor} - {rndCity}.\r\n");

            Console.WriteLine($"{rndPhrase} {rndEvent} {rndAuthor} - {rndCity}.");
        }
    }
}

