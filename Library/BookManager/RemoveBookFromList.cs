using Library.BookBase;

namespace Library.BookManager;

public class RemoveBookFromList : IManageStrategy
{
    public IManageStrategy Manage(IBook book)
    {
        BaseOfBook.books.RemoveAll(item => item.Id == book.Id);
        return this;
    }
}