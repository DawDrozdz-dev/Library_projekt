namespace Library.BookManager;

public class Context
{
    private readonly ManageStrategy _manageStrategy;

    public Context(ManageStrategy strategy)
    {
        _manageStrategy = strategy;
    }

    public ManageStrategy Manage(IBook book)
    {
        var result = _manageStrategy.Manage(book);
        return result;
    }
}