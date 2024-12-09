namespace Library.BookManager;

public class RemoveBookFromList : ManageStrategy
{
    public override ManageStrategy Manage(IBook book)
    {
        foreach (var item in books)
        {
            if (item.Id == book.Id)
            {
                books.Remove(item);
            }
        }
        return this;
    }
}