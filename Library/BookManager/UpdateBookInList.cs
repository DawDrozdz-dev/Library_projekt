using Library.BookBase;

namespace Library.BookManager;

public class UpdateBookInList : IManageStrategy
{
    public IManageStrategy Manage(IBook book)
    {
        foreach (var item in BaseOfBook.books)
        {
            if (item.Id == book.Id)
            {
                item.Author = book.Author;
                item.Price = book.Price;
                item.Description = book.Description;
                item.Title = book.Title;
                item.Id = book.Id;
            }
        }
        Console.WriteLine("Book has been updated.");
        return this;
    }
}