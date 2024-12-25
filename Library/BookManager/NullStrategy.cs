namespace Library.BookManager;

public class NullStrategy : IManageStrategy
{
    public IManageStrategy Manage(IBook book)
    {
        return null;
    }
}