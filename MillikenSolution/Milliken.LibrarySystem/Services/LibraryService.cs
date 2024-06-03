using System;
using System.Collections.Generic;
using Milliken.LibrarySystem.Models;
using Milliken.LibrarySystems.Interfaces;

namespace Milliken.LibrarySystem.Services
{
    public class LibraryService : ILibraryService
    {
        private Library _library;
        public List<Book> Books { get; set; } = new List<Book>();
        public List<EBook> EBooks { get; set; } = new List<EBook>();
        public LibraryService(Library library)
        {
            _library = library;
        }
       
        // List Books
        public void ListAllBooks()
        {
            Console.WriteLine("Books in " + _library.Name + ":");
            foreach (var book in Books)
            {
                Console.WriteLine("- " + book.Title + " by " + book.Author + " published in " + book.YearPublished);
            }
            Console.WriteLine("EBooks in " + _library.Name + ":");
            foreach (var eBook in EBooks)
            {
                Console.WriteLine("- " + eBook.Title + " by " + eBook.Author + " published in " + eBook.YearPublished);
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

        // Find EBook
        public EBook FindEBookByTitle(string title)
        {
            foreach (var eBook in EBooks)
            {
                if (eBook.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    return eBook;
                }
            }
            return null;
        }

        // Remove Book
        public Book RemoveBooksByTitle(string title)
        {
            var book = FindBookByTitle(title);
            if (book != null)
            {
                Books.Remove(book);
                return book;
            }
            var eBook = FindEBookByTitle(title);
            if (eBook != null)
            {
                EBooks.Remove(eBook);
                return eBook;
            }
            return null;
        }

        // Total Books and EBooks
        public int TotalBooksAndEBooks() => EBooks.Count + Books.Count;
        public void InitializeData()
        {
            // Create Books
            Book book1 = new Book("Harry Potter and the Goblet of Fire", "J.K. Rowling", 550, 2000);
            Book book2 = new Book("To Kill a Mockingbird", "Harper Lee", 320, 1960);
            Book book3 = new Book("1984", "George Orwell", 398, 1949);
            Book book4 = new Book("The Stranger", "Albert Camus", 320, 1942);
            Book book5 = new Book("Harry Potter and the Sorcerer's Stone", "J.K. Rowling", 311, 1997);

            // Create EBooks
            EBook ebook1 = new EBook("The Hobbit", "J. R. R. Tolkien", 346, 1937, 1.5);
            EBook ebook2 = new EBook("The Lightning Thief", "Rick Riordan", 380, 2005, 2.0);
            EBook ebook3 = new EBook("The Martian", "Andy Weir", 450, 2011, 2.1);
            EBook ebook4 = new EBook("Precious", "Sapphire", 241, 1996, 1.2);
            EBook ebook5 = new EBook("Beloved", "Toni Morrison", 289, 1987, 1.4);

            Books.Add(book1);
            Books.Add(book2);
            Books.Add(book3);
            Books.Add(book4);
            Books.Add(book5);

            EBooks.Add(ebook1);
            EBooks.Add(ebook2);
            EBooks.Add(ebook3);
            EBooks.Add(ebook4);
            EBooks.Add(ebook5);
        }
    }

}