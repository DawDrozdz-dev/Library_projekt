using Library.BookManager;
namespace Library.BookManager;

public abstract class UpdateBookManager : ManageStrategy, ITakeBookFromList
{
    public bool GetBook(int id)
    {
        foreach (var book in books)
        {
            if (book.Id == id)
            {
                return true;
            }
        }
        return false;
    }
}