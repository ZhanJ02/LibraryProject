using Milliken.LibrarySystem.Models;

namespace Milliken.LibrarySystems.Interfaces
{
    public interface ILibraryService
    {
        // Interface for Library class
        void ListAllBooks();
        Book FindBookByTitle(string title);
        EBook FindEBookByTitle(string title);
        Book RemoveBooksByTitle(string title);
        int TotalBooksAndEBooks();
        void InitializeData();
    }
}