using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

public class BookLibrary
{
    public static void Main()
    {
        File.WriteAllText("Input.txt", "");
        File.WriteAllText("Output.txt", "");

        List<Book> books = ReadBooks();
        Library library = ReadLibrary(books);
        Dictionary<string, DateTime> orderedBooks = GetBooksOrdered(library);
        PrintBooks(orderedBooks);
    }

    static void PrintBooks(Dictionary<string, DateTime> orderedBooks)
    {
        string dateStr = Console.ReadLine();
        File.AppendAllText("Input.txt", dateStr + Environment.NewLine);
        DateTime date = DateTime.ParseExact(dateStr, "dd.MM.yyyy", CultureInfo.InvariantCulture);

        foreach (var pair in orderedBooks.OrderBy(d => d.Value).ThenBy(t => t.Key).Where(d => d.Value > date))
        {
            File.AppendAllText("Output.txt", $"{pair.Key} -> {pair.Value:dd.MM.yyyy}\r\n");
            Console.WriteLine($"{pair.Key} -> {pair.Value:dd.MM.yyyy}");
        }
    }

    static Dictionary<string, DateTime> GetBooksOrdered(Library library)
    {
        Dictionary<string, DateTime> orderedBooks = new Dictionary<string, DateTime>();

        foreach (var entry in library.Books)
        {
            if (!orderedBooks.ContainsKey(entry.Title))
            {
                orderedBooks.Add(entry.Title, entry.ReleaseDate);
            }
            else
            {
                orderedBooks[entry.Title] = entry.ReleaseDate;
            }
        }

        return orderedBooks;
    }

    static Library ReadLibrary(List<Book> books)
    {
        Library library = new Library();
        library.Name = "First Library";
        library.Books = books;

        return library;
    }

    static List<Book> ReadBooks()
    {
        int n = int.Parse(Console.ReadLine());
        File.AppendAllText("Input.txt", n.ToString() + Environment.NewLine);
        List<Book> books = new List<Book>();

        for (int i = 0; i < n; i++)
        {
            Book book = ReadBook();
            books.Add(book);
        }

        return books;
    }

    static Book ReadBook()
    {
        string input = Console.ReadLine();
        string[] bookInfo = input.Split(' ');
        File.AppendAllText("Input.txt", input + Environment.NewLine);

        string title = bookInfo[0];
        string author = bookInfo[1];
        string publisher = bookInfo[2];
        string releaseD = bookInfo[3];
        DateTime releaseDate = DateTime.ParseExact(releaseD, "dd.MM.yyyy", CultureInfo.InvariantCulture);
        string isbn = bookInfo[4];
        decimal price = decimal.Parse(bookInfo[5]);

        Book book = new Book();
        book.Title = title;
        book.Author = author;
        book.Publisher = publisher;
        book.ReleaseDate = releaseDate;
        book.ISBNNumber = isbn;
        book.Price = price;

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


