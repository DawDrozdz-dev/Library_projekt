namespace Library.BookManager;

public class AddBookToList : ManageStrategy
{
    public override ManageStrategy Manage(IBook book)
    {
       books.Add(book);
       Console.WriteLine($"{book} added to list");
       return this;
    }
}