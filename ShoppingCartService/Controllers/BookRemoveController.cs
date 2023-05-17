using Microsoft.AspNetCore.Mvc;
using LibraryService.Interface;
using LibraryService.Models;

namespace LibraryService.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class BookRemoveController : ControllerBase
    {
        private IBookService _bookService;
        public BookRemoveController(IBookService book)
        {
            _bookService = book;
        }
        [HttpGet(Name = "RemoveBook")]
        public string ProductRemove([FromQuery] Book book) => _bookService.BookRemove(book);
    }

}
