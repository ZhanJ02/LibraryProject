using System;
using System.Collections.Generic;
using Milliken.Book;

namespace Milliken.Library
{
    public class Library
    {
        // Properties
        public string Name { get; set; } = "Unnamed Library";
        public string Location { get; set; } = "Unknown Location";
        public List<Book> Books { get; set; } = new List<Book>();

        // Parameterized Constructor
        public Library(string name, string location)
        {
            Name = name;
            Location = location;
        }

        // Add Book
        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        // List Books
        public void ListBooks()
        {
            Console.WriteLine("Books in " + Name + ":");
            foreach (var book in Books)
            {
                Console.WriteLine("- " + book.Title + " by " + book.Author);
                if (book is EBook ebook)
                {
                    Console.WriteLine("  (EBook) File Size: " + ebook.FileSize + " MB");
                }
            }
        }

        // Find Book
        public Book FindBookByTitle(string title)
        {
            foreach (var book in Books)
            {
                if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    return book;
                }
            }
            return null;
        }

        // Remove Book
        public bool RemoveBookByTitle(string title)
        {
            var book = FindBookByTitle(title);
            if (book != null)
            {
                Books.Remove(book);
                return true;
            }
            return false;
        }

        // Total Books
        public int GetTotalBooks()
        {
            return Books.Count;
        }
    }
}
