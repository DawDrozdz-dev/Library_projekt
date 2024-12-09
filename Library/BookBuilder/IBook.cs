namespace Library.BookManager;

public interface IBook
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public int Id { get; set; }
}