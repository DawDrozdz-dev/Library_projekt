using Library.BookManager;
namespace Library.BookManager;

public abstract class UpdateBookManager : ManageStrategy, ITakeBookFromList
{
    private readonly ManageStrategy _strategy;
    private List<IBook> _booksToUpdate = new List<IBook>();

    public UpdateBookManager(ManageStrategy strategy)
    {
        _strategy = strategy;
    }
    public void GetBook(int id)
    {
        foreach (var book in books)
        {
            if (book.Id == id)
            {
                _booksToUpdate.Add(book);
                foreach (var books in _booksToUpdate)
                {
                    _strategy.Manage(books);
                }
                
            }
        }
    }
}