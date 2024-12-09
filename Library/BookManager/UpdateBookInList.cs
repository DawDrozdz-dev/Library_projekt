namespace Library.BookManager;

public class UpdateBookInList : ManageStrategy
{
    public override ManageStrategy Manage(IBook book)
    {
        foreach (var item in books)
        {
            if (item.Id == book.Id)
            {
                item.Author = book.Author;
                item.Price = book.Price;
                item.Description = book.Description;
                item.Title = book.Title;
            }
        }
        return this;
    }
}