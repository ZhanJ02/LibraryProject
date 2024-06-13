using Milliken.LibrarySystem.Models;

namespace Milliken.API.Interfaces
{
    public interface ILibraryControllers
    {
        List<Book> GetBooks();
        List<EBook> GetEBooks();
        int TotalNumberOfAllBooks();
        List<Book> DeleteBook(string title);
        List<EBook> DeleteEBook(string eTitle);

        List<Book> AddBook(string title, string author, int pages, int yearPublished);
        List<EBook> AddEBook(string title, string author, int pages, int yearPublished, double fileSize);
    }
}