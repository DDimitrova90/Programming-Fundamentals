using System;
using System.Collections.Generic;
using System.IO;

public class BookLibrary
{
    public static void Main()
    {
        File.WriteAllText("Input.txt", "");
        File.WriteAllText("Output.txt", "");

        List<Book> books = ReadBooks();
        Library library = ReadLibrary(books);
        Dictionary<string, decimal> orderedBooks = GetBooksOrdered(library);
        PrintBooks(orderedBooks);
    }

    static void PrintBooks(Dictionary<string, decimal> orderedBooks)
    {
        foreach (var pair in orderedBooks)
        {
            File.AppendAllText("Output.txt", $"{pair.Key} -> {pair.Value:F2}\r\n");
            Console.WriteLine($"{pair.Key} -> {pair.Value:F2}");
        }
    }

    static Dictionary<string, decimal> GetBooksOrdered(Library library)
    {
        Dictionary<string, decimal> orderedBooks = new Dictionary<string, decimal>();

        foreach (var entry in library.Books)
        {
            if (!orderedBooks.ContainsKey(entry.Author))
            {
                orderedBooks[entry.Author] = entry.Price;
            }
            else
            {
                orderedBooks[entry.Author] += entry.Price;
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
        string releaseDate = bookInfo[3];
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
    public string ReleaseDate { get; set; }
    public string ISBNNumber { get; set; }
    public decimal Price { get; set; }
}

public class Library
{
    public string Name { get; set; }
    public List<Book> Books { get; set; }
}

