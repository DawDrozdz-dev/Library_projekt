namespace Library.BookManager;

public class Context
{
    private readonly IManageStrategy _manageStrategy;

    public Context(IManageStrategy strategy)
    {
        _manageStrategy = strategy;
    }

    public IManageStrategy Manage(IBook book)
    {
        var result = _manageStrategy.Manage(book);
        return result;
    }
}