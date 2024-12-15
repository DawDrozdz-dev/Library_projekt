using Library.BookBase;

namespace Library.BookManager;

public class AddBookToList : IManageStrategy
{
    public IManageStrategy Manage(IBook book)
    {
       BaseOfBook.books.Add(book);
       return this;
    }
}