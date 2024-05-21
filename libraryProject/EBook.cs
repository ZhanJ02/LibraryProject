using System;
using Milliken.Book;

namespace Milliken.EBook
{
    public class EBook : Book
    {
        // Properties
        public double FileSize { get; set; } = 100.0;

        // Parameterized Constructor
        public EBook(string title, string author, string genre, int pages, int yearPublished, double fileSize)
            : base(title, author, genre, pages, yearPublished)
        {
            FileSize = fileSize;
        }

        // Print Function
        public void PrintEBookDetails()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Genre: " + Genre);
            Console.WriteLine("Pages: " + Pages);
            Console.WriteLine("Year Published: " + YearPublished);
            Console.WriteLine("File Size: " + FileSize + " MB");
        }
    }
}
