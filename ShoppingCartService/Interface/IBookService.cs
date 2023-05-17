using LibraryService.Models;

namespace LibraryService.Interface
{
    public interface IBookService
    {
        string BookAdd(Book book);
        string BookRemove(Book book);
        string BookShow();
    }
}
