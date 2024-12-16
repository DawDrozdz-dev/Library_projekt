namespace Library.BookManager;

public class Comic : IBook
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public int Id { get; set; }
    public override string ToString()
    {
        return $"Title: {Title} \n Author: {Author} \n Description: {Description}\n Price: {Price}, Id: {Id} \n";
    }
}