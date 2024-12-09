namespace Library.BookManager;

public abstract class ManageStrategy
{
    protected List<IBook> books = new List<IBook>(){ new Comic()
    {
        Author = "dawid", Description = "test", Title = "test", Id = 1, Price = 45.55,
        
    }};
    
    public abstract ManageStrategy Manage(IBook book);

    public void Read()
    {
        foreach (IBook book in books)
        {
            Console.WriteLine(string.Join(",", books));
        }
        
    }
}