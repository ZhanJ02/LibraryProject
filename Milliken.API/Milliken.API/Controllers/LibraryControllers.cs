using Microsoft.AspNetCore.Mvc;
using Milliken.API.Interfaces;
using Milliken.LibrarySystem.Interfaces;
using Milliken.LibrarySystem.Models;

namespace Milliken.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LibraryControllers : ILibraryControllers
    {
        private readonly ILogger<LibraryControllers> _logger;
        private readonly ILibraryService _libraryService;

        public LibraryControllers(ILogger<LibraryControllers> logger, ILibraryService libraryService)
        {
            _logger = logger;
            _libraryService = libraryService;
            _libraryService.InitializeBookData();
            _libraryService.InitializeEBookData();
        }

        [HttpGet("Books in Library")]
        public List<Book> GetBooks()
        {
            _libraryService.ListAllBooks();
            return _libraryService.InitializeBookData();
        }

        [HttpGet("EBooks in Library")]
        public List<EBook> GetEBooks()
        {
            _libraryService.ListAllBooks();
            return _libraryService.InitializeEBookData();
        }

        [HttpGet("Total Books and EBooks")]
        public int TotalNumberOfAllBooks()
        {
            return _libraryService.TotalBooksAndEBooks();
        }

        [HttpDelete("Books in Library/{title}")]
        public List<Book> DeleteBook(string title)
        {
            var books = _libraryService.RemoveBooksByTitle(title);
            _libraryService.ListAllBooks();
            return books;
        }

        [HttpDelete("EBooks in Library/{eTitle}")]
        public List<EBook> DeleteEBook(string eTitle)
        {
            var ebooks = _libraryService.RemoveEBooksByTitle(eTitle);
            _libraryService.ListAllBooks();
            return ebooks;
        }

        [HttpPost("Add Books to Library")] 
        public List<Book> AddBook(string author, string title, int pages, int yearPublished)
        {
            var books = _libraryService.AddBooks(author, title, pages, yearPublished);
            _libraryService.ListAllBooks();

            return books;
        }

        [HttpPost("Add Electronic Books to Library")]
        public List<EBook> AddEBook(string author, string title, int pages, int yearPublished, double fileSize)
        {
            var ebooks = _libraryService.AddEBooks(author, title, pages, yearPublished, fileSize);
            _libraryService.ListAllBooks();
            return ebooks;
        }

    }
}
