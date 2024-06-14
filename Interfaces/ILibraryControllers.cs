using Milliken.LibraryAPI.Models;

namespace Milliken.LibraryAPI.Interfaces
{
    public interface ILibraryControllers
    {
        HashSet<Book> GetBooks();
        HashSet<EBook> GetEBooks();
        int TotalNumberOfAllBooks();
        HashSet<Book> DeleteBook(string title);
        HashSet<EBook> DeleteEBook(string eTitle);

        HashSet<Book> AddBook(string title, string author, int pages, int yearPublished);
        HashSet<EBook> AddEBook(string title, string author, int pages, int yearPublished, double fileSize);
    }
}