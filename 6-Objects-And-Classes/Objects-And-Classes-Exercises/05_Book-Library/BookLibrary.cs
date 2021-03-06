﻿using System;
using System.Collections.Generic;
using System.Linq;

public class BookLibrary
{
    public static void Main()
    {
        Library firstLibrary = ReadLibrary();

        Dictionary<string, decimal> orderedBooks = GetBooksOrdered(firstLibrary);

        PrintBooks(orderedBooks);
    }

    static void PrintBooks(Dictionary<string, decimal> orderedBooks)
    {
        var orderedLib = orderedBooks
            .OrderByDescending(p => p.Value)
            .ThenBy(a => a.Key);
        foreach (var pair in orderedLib)
        {
            Console.WriteLine("{0} -> {1:F2}", pair.Key, pair.Value);
        }
    }

    static Dictionary<string, decimal> GetBooksOrdered(Library firstLibrary)
    {
        Dictionary<string, decimal> orderedBooks = new Dictionary<string, decimal>();

        foreach (var pair in firstLibrary.Books)
        {
            if (!orderedBooks.ContainsKey(pair.Author))
            {
                orderedBooks.Add(pair.Author, 0);
            }

            orderedBooks[pair.Author] += pair.Price;
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
        book.ReleaseDate = bookInfo[3];
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
    public string ReleaseDate { get; set; }
    public string ISBNNumber { get; set; }
    public decimal Price { get; set; }
}

public class Library
{
    public string Name { get; set; }
    public List<Book> Books { get; set; }
}
