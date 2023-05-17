using LibraryService.Interface;
using LibraryService.Models;

namespace LibraryService.Services
{
    public class BookService : IBookService
    {
        public static Book[] FakeData = new Book[5]; 
        int counter = 0;

        public string BookAdd(Book book)
        {
            FakeData[counter] = new Book();
            FakeData[counter].ID = book.ID;
            FakeData[counter].Title = book.Title;
            FakeData[counter].Year = book.Year;
            counter++;
            return "The book has been added succsesfully";
        }
        public string BookRemove(Book book)
        {
            for(int i = 0; i <= counter; i++)
            {
                if(FakeData[i].Title== book.Title)
                {
                    if(FakeData[i].ID == book.ID)
                    {
                        FakeData[i].Year = 0;
                        FakeData[i].ID = "";
                        FakeData[i].Title = "";
                        return "Removed";
                    }
                }
            }
            return "There was no Book found with this name and ID please check the credentials";
        }
        public string BookShow()
        {
            string ToReturn = "";
            for (int i = 0; i <= counter; i++)
            {
                ToReturn = "Book:" + i + "." + FakeData[i].ID + "   " +FakeData[i].Title + "YEAR:" + FakeData[i].Year ;
            }
            return ToReturn;
        }
    }
}
