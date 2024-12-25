using Library.BookBase;

namespace Library.BookManager;

public class RemoveBookFromList : IManageStrategy
{
    private static NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();
    public IManageStrategy Manage(IBook book)
    {
        if (!BaseOfBook.books.Any(item => item.Id == book.Id))
        {
            throw new ArgumentException($"\n Book with ID {book.Id} does not exist.");
        }
        BaseOfBook.books.RemoveAll(item => item.Id == book.Id);
        _logger.Info($"\nBook with ID {book.Id} has been removed from library.");
        Console.WriteLine($"\nBook with ID {book.Id} has been removed from library.");
        return this;
    }
}