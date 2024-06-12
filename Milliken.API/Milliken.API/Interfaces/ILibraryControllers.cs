using Milliken.LibrarySystem.Models;

namespace Milliken.API.Interfaces
{
    public interface ILibraryControllers
    {
        List<Book> GetBooks();
        List<EBook> GetEBooks();
        int TotalNumberOfAllBooks();
        Book DeleteBook(string title);
        Book AddBook(string title, string author, int pages, int yearPublished);
        Book AddEBook(string title, string author, int pages, int yearPublished, double fileSize);
    }
}