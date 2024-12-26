using Library.BookBase;
namespace Library.BookManager;

public class TakeBookFromList : ITakeBookFromList
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