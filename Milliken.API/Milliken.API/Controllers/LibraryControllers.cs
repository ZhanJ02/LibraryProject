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
        }

        [HttpPut]
        public List<Book> GetBooks()
        {
            return _libraryService.InitializeBookData();
        }

        [HttpPut]
        public List<EBook> GetEBooks()
        {
            return _libraryService.InitializeEBookData();
        }

        [HttpPut]
        public int TotalNumberOfAllBooks()
        {
            return _libraryService.TotalBooksAndEBooks();
        }

        [HttpDelete("{title}")]
        public Book DeleteBook(string title)
        {
            var book = _libraryService.RemoveBooksByTitle(title);
            if (_libraryService.RemoveBooksByTitle(title) == null)
            {
                return null;
            }
            else
            {
                return book;
            }
        }

        [HttpPost] 
        public Book AddBook(string author, string title, int pages, int yearPublished)
        {
            var book = _libraryService.AddBooks(author, title, pages, yearPublished);
            return book;
        }

        [HttpPost]
        public Book AddEBook(string author, string title, int pages, int yearPublished, double fileSize)
        {
            var eBook = _libraryService.AddEBooks(author, title, pages, yearPublished, fileSize);
            return eBook;
        }

    }
}
