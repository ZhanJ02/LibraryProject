using Milliken.LibrarySystem.Models;

namespace Milliken.LibrarySystems.Interfaces
{
    public interface ILibraryService
    {
        // Interface for Library class
        void AddBook(Book book);
        void AddEBook(EBook eBook);
        void ListAllBooks();
        Book FindBookByTitle(string title);
        EBook FindEBookByTitle(string title);
        bool RemoveBooksByTitle(string title);
        int TotalBooksAndEBooks();
    }
}