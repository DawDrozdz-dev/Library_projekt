using Library.BookBase;
using Library.BookManager;

namespace Library.UserInterfaceExecutors;

public class FacadeForReadBook : IFacade
{
    public IBook Execute()
    {
        if (BaseOfBook.books.Count == 0)
        {
            Console.WriteLine("Brak książek w bazie.");
            return null;
        }

        Console.WriteLine("Dostępne książki:");
        foreach (var book in BaseOfBook.books)
        {
            Console.WriteLine($"ID: {book.Id}, Tytuł: {book.Title}");
        }
        return BaseOfBook.books[0];
    }
}