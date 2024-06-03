using System;
using Milliken.LibrarySystem.Models;
using Milliken.LibrarySystem.Services;
using Microsoft.Extensions.Logging;


namespace Milliken.ConsoleApp.TestingLibrarySystem
{
    class Testing
    {
        static void Main()
        {
            // Create Library
            Library library = new Library("Milliken Library", "Spartanburg");

            // Initializing Service and Data
            LibraryService service = new LibraryService(library);
            service.InitializeData();

            // List Books and EBooks
            service.ListAllBooks();

            // Find Books
            Console.WriteLine("Enter Book name to find");
            string title = Console.ReadLine();
            Book foundBook = service.FindBookByTitle(title);
            if (foundBook != null)
            {
                Console.WriteLine("Found Book: " + title);
            }
            else
            {
                Console.WriteLine("Book not found");
            }
            // Find EBooks
            Console.WriteLine("Enter EBook name to find");
            string eTitle = Console.ReadLine();
            EBook foundEBook = service.FindEBookByTitle(eTitle);
            if (foundEBook != null)
            {
                Console.WriteLine("Found EBook: " + eTitle);
            }
            else
            {
                Console.WriteLine("EBook not found");
            }

            // Remove Books
            Console.WriteLine("Enter Book or EBook name to remove");
            string remove = Console.ReadLine();
            if (service.RemoveBooksByTitle(remove) != null)
            {
                Console.WriteLine("Book removed: " + remove);
            }
            else
            {
                Console.WriteLine("No Book found");
            }
            service.ListAllBooks();

            // Display All Books
            Console.WriteLine("Total Books and EBooks " + service.TotalBooksAndEBooks());
        }
    }
}