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
        Book RemoveBooksByTitle(string title);
        Book AddBooks(string title, string author, int pages, int yearPublished);
        Book AddEBooks(string title, string author, int pages, int yearPublished, double fileSize);
        int TotalBooksAndEBooks();
        List<Book> InitializeBookData();
        List<EBook> InitializeEBookData();
    }
}