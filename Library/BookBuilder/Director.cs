using Library.BookManager;

namespace Library.UserInterFaceExecutor;

public class Director : IDirector
{
    private readonly IBookBuilder _bookBuilder;

    public Director(IBookBuilder bookBuilder)
    {
        _bookBuilder = bookBuilder;
    }

    public IBook BuildBook(string author, string title, string description, double price, int bookId)
    {
        _bookBuilder.SetPrice(price);
        _bookBuilder.SetDescription(description);
        _bookBuilder.SetTitle(title);
        _bookBuilder.SetAuthor(author);
        _bookBuilder.SetId(bookId);
        IBook book = _bookBuilder.Build();
        return book;
    }
}
