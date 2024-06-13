using Milliken.LibrarySystem.Models;
using System.Security;

namespace Milliken.LibrarySystem.Interfaces
{
    public interface ILibraryService
    {
        // Interface for Library class
        void ListAllBooks();
        Book FindBookByTitle(string title);
        EBook FindEBookByTitle(string title);
        List<Book> RemoveBooksByTitle(string title);
        List<EBook> RemoveEBooksByTitle(string title);
        List<Book> AddBooks(string title, string author, int pages, int yearPublished);
        List<EBook> AddEBooks(string title, string author, int pages, int yearPublished, double fileSize);
        int TotalBooksAndEBooks();
        List<Book> InitializeBookData();
        List<EBook> InitializeEBookData();
    }
}