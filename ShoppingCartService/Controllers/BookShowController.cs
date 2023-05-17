using Microsoft.AspNetCore.Mvc;
using LibraryService.Interface;

namespace LibraryService.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class BookShowController
    {
        private IBookService _bookService;
        public BookShowController(IBookService book)
        {
            _bookService = book;
        }
        [HttpGet(Name = "ShowBook")]
        public string ProductShow() => _bookService.BookShow();
    }
}
