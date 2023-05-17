using Microsoft.AspNetCore.Mvc;
using LibraryService.Interface;
using LibraryService.Models;

namespace LibraryService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private IBookService _bookService;    
        public BookController(IBookService book)
        {
            _bookService = book;
        }
        [HttpGet(Name = "AddBook")]
        public string ProductAdd([FromQuery] Book book) => _bookService.BookAdd(book);
    }
}
