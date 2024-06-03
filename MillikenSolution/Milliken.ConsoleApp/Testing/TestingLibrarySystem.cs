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

            // Setup Logger
            using var loggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });
            ILogger log = loggerFactory.CreateLogger<Testing>();

            // Initializing Service and Data
            LibraryService service = new LibraryService(library);
            service.InitializeData();

            // List Books and EBooks
            service.ListAllBooks();

            // Find Books
            log.LogInformation("Enter book name to find.");
            string title = Console.ReadLine();
            Book foundBook = service.FindBookByTitle(title);
            if (foundBook != null)
            {
                log.LogInformation($"Found Book: {title}");
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
                log.LogInformation($"Found EBook: {eTitle}");
            }
            else
            {
                log.LogInformation("EBook not found");
            }

            // Remove Books
            Console.WriteLine("Enter Book or EBook name to remove");
            string remove = Console.ReadLine();
            if (service.RemoveBooksByTitle(remove) != null)
            {
                log.LogInformation($"Book removed: {remove}");
            }
            else
            {
                log.LogInformation("No Book found");
            }
            service.ListAllBooks();

            // Display All Books
            log.LogInformation($"Total Books and EBooks {service.TotalBooksAndEBooks()}");
        }
    }
}