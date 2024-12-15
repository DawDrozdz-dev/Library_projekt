using Library.BookBase;
using Library.BookManager;
namespace Library.BookManager;

public class UpdateBookManager : ITakeBookFromList
{
    public bool GetBook(int id)
    {
        foreach (var book in BaseOfBook.books)
        {
            if (book.Id == id)
            {
                return true;
            }
        }
        return false;
    }
}