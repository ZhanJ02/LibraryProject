using Milliken.LibrarySystem.Models;
namespace Milliken.LibrarySystem.Interfaces
{
    public interface ILibraryService
    {
        // Interface for Library class
        void InitializeBookData();
        void InitializeEBookData();
        HashSet<Book> ListBooks();
        HashSet<EBook> ListEBooks();
        Book FindBookByTitle(string title);
        EBook FindEBookByTitle(string title);
        HashSet<Book> RemoveBooksByTitle(string title);
        HashSet<EBook> RemoveEBooksByTitle(string title);
        HashSet<Book> AddBooks(string title, string author, int pages, int yearPublished);
        HashSet<EBook> AddEBooks(string title, string author, int pages, int yearPublished, double fileSize);
        int TotalBooksAndEBooks();
    }
}