using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class BookLibrary
{
    public static void Main()
    {
        Library firstLibrary = ReadLibrary();

        Dictionary<string, DateTime> orderedBooks = GetBooksOrdered(firstLibrary);

        PrintBooks(orderedBooks);
    }

    static void PrintBooks(Dictionary<string, DateTime> orderedBooks)
    {
        string date = Console.ReadLine();
        DateTime currDate = DateTime.ParseExact(date, "dd.MM.yyyy", CultureInfo.InvariantCulture);

        foreach (var pair in orderedBooks.OrderBy(d => d.Value).ThenBy(t => t.Key))
        {
            if (pair.Value > currDate)
            {
                Console.WriteLine("{0} -> {1:dd.MM.yyyy}", pair.Key, pair.Value);
            }
        }
    }

    static Dictionary<string, DateTime> GetBooksOrdered(Library firstLibrary)
    {
        Dictionary<string, DateTime> orderedBooks = new Dictionary<string, DateTime>();

        foreach (var pair in firstLibrary.Books)
        {
            orderedBooks[pair.Title] = pair.ReleaseDate;
        }

        return orderedBooks;
    }

    static Library ReadLibrary()
    {
        int n = int.Parse(Console.ReadLine());
        List<Book> books = new List<Book>();

        for (int i = 0; i < n; i++)
        {
            books.Add(ReadBook());
        }

        return new Library
        {
            Name = "First Library",
            Books = books
        };
    }

    static Book ReadBook()
    {
        string[] bookInfo = Console.ReadLine().Split(' ');

        Book book = new Book();
        book.Title = bookInfo[0];
        book.Author = bookInfo[1];
        book.Publisher = bookInfo[2];
        book.ReleaseDate = DateTime.ParseExact(bookInfo[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
        book.ISBNNumber = bookInfo[4];
        book.Price = decimal.Parse(bookInfo[5]);

        return book;
    }
}

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public DateTime ReleaseDate { get; set; }
    public string ISBNNumber { get; set; }
    public decimal Price { get; set; }
}

public class Library
{
    public string Name { get; set; }
    public List<Book> Books { get; set; }
}
