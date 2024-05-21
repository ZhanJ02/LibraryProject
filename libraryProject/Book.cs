using System;

namespace Milliken.Book
{
    public class Book
    {
        // Properties
        public string Title { get; set; } = "Unknown";
        public string Author { get; set; } = "Unknown";
        public string Genre { get; set; } = "Fiction";
        public int Pages { get; set; } = 1;
        public int YearPublished { get; set; } = 1900;

        // Parameterized Constructor
        public Book(string title, string author, string genre, int pages, int yearPublished)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Pages = pages;
            YearPublished = yearPublished;
        }

        // Print Book Details
        public void PrintDetails()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Genre: " + Genre);
            Console.WriteLine("Pages: " + Pages);
            Console.WriteLine("Year Published: " + YearPublished);
        }
    }
}
