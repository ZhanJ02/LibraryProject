using Milliken.Book;
using Milliken.Library;
using Milliken.EBook;
using System;

class Main
{
    static void Main()
    {
        // Create Library
        Library myLibrary = new Library("Central Library", "Main Street");

        // Create Books
        Book book1 = new Book("1984", "George Orwell", "Dystopian", 328, 1949);
        Book book2 = new Book("To Kill a Mockingbird", "Harper Lee", "Fiction", 281, 1960);

        // Create EBooks
        EBook ebook1 = new EBook("Digital Fortress", "Dan Brown", "Thriller", 356, 1998, 2.5);
        EBook ebook2 = new EBook("The Martian", "Andy Weir", "Science Fiction", 387, 2011, 1.8);

        // Adding Books
        myLibrary.AddBook(book1);
        myLibrary.AddBook(book2);
        myLibrary.AddBook(ebook1);
        myLibrary.AddBook(ebook2);

        // List Books
        myLibrary.ListBooks();

        // Finding Books
        Book foundBook = myLibrary.FindBookByTitle("1984");
        if (foundBook != null)
        {
            Console.WriteLine("Found book: " + foundBook.Title + " by " + foundBook.Author);
        }

        // Removing Book
        bool removed = myLibrary.RemoveBookByTitle("The Martian");
        Console.WriteLine("Book removed: " + removed);

        // Getting Total Books
        int totalBooks = myLibrary.GetTotalBooks();
        Console.WriteLine("Total books in library: " + totalBooks);
    }
}
