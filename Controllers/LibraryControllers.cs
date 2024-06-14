using Microsoft.AspNetCore.Mvc;
using Milliken.LibraryAPI.Interfaces;
using Milliken.LibraryAPI.Models;

namespace Milliken.LibraryAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LibraryControllers : ILibraryControllers
    {
        private readonly ILibraryService _libraryService;

        public LibraryControllers(ILibraryService libraryService)
        {
            _libraryService = libraryService;
        }

        [HttpGet("Books in Library")]
        public HashSet<Book> GetBooks()
        {
            return _libraryService.ListBooks();

        }

        [HttpGet("EBooks in Library")]
        public HashSet<EBook> GetEBooks()
        {
            return _libraryService.ListEBooks();
        }

        [HttpGet("Total Books and EBooks")]
        public int TotalNumberOfAllBooks()
        {
            return _libraryService.TotalBooksAndEBooks();
        }

        [HttpDelete("Books in Library/{title}")]
        public HashSet<Book> DeleteBook(string title)
        {
            _libraryService.RemoveBooksByTitle(title);
            return _libraryService.ListBooks();
        }

        [HttpDelete("EBooks in Library/{eTitle}")]
        public HashSet<EBook> DeleteEBook(string eTitle)
        {
            _libraryService.RemoveEBooksByTitle(eTitle);
            return _libraryService.ListEBooks();
        }

        [HttpPost("Add Books to Library")]
        public HashSet<Book> AddBook(string author, string title, int pages, int yearPublished)
        {
            _libraryService.AddBooks(author, title, pages, yearPublished);
            return _libraryService.ListBooks();
        }

        [HttpPost("Add Electronic Books to Library")]
        public HashSet<EBook> AddEBook(string author, string title, int pages, int yearPublished, double fileSize)
        {
            _libraryService.AddEBooks(author, title, pages, yearPublished, fileSize);
            return _libraryService.ListEBooks();
        }

    }
}
