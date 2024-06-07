using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Milliken.LibrarySystem.Models;
using Milliken.LibrarySystem.Services;
using Milliken.LibrarySystems.Interfaces;

namespace Milliken.ConsoleApp.TestingLibrarySystem
{
    class Testing
    {
        static void Main()
        {
            // Setup DI
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<Library>(new Library("Milliken Library", "Spartanburg"));
            serviceCollection.AddTransient<ILibraryService, LibraryService>();

            // Setup Logger
            serviceCollection.AddLogging(builder => { builder.AddConsole(); });

            // Build the Service Provider
            var serviceProvider = serviceCollection.BuildServiceProvider();

            // Resolve Services
            var libraryService = serviceProvider.GetService<ILibraryService>();
            var log = serviceProvider.GetService<ILogger<Testing>>();

            // Initialize data
            libraryService.InitializeData();

            // List Books and EBooks
            libraryService.ListAllBooks();

            // Find Books
            log.LogInformation("Enter book name to find.");
            string title = Console.ReadLine();
            var foundBook = libraryService.FindBookByTitle(title);
            if (foundBook != null)
            {
                log.LogInformation($"Found Book: {title}");
            }
            else
            {
                log.LogInformation("Book not found");
            }

            // Find EBooks
            log.LogInformation("Enter EBook name to find");
            string eTitle = Console.ReadLine();
            var foundEBook = libraryService.FindEBookByTitle(eTitle);
            if (foundEBook != null)
            {
                log.LogInformation($"Found EBook: {eTitle}");
            }
            else
            {
                log.LogInformation("EBook not found");
            }

            // Remove Books
            log.LogInformation("Enter Book or EBook name to remove");
            string remove = Console.ReadLine();
            if (libraryService.RemoveBooksByTitle(remove) != null)
            {
                log.LogInformation($"Book removed: {remove}");
            }
            else
            {
                log.LogInformation("No Book found");
            }
 
            // Display All Books
            log.LogInformation($"Total Books and EBooks {libraryService.TotalBooksAndEBooks()}");
        }
    }
}