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

        Console.WriteLine("Dostępne książki:\n");
        foreach (var book in BaseOfBook.books)
        {
            Console.WriteLine($"Book title; {book.Title}\n " +
                $"Author; {book.Author}\n " +
                $"Price; {book.Price}\n " +
                $"Description; {book.Description}\n" +
                $"ID: {book.Id}\n");
        }
        return BaseOfBook.books[0];
    }
}