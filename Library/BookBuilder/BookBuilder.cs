using Library.BookManager;

namespace Library.UserInterFaceExecutor;

public class BookBuilder : IBookBuilder
{
    private readonly IBook comic = new Comic();
    public void SetTitle(string title)
    {
        comic.Title = title;
    }

    public void SetAuthor(string author)
    {
        comic.Author = author;
    }

    public void SetDescription(string description)
    {
        comic.Description = description;
    }

    public void SetPrice(double price)
    {
        comic.Price = price;
    }

    public void SetId(int id)
    {
        comic.Id = id;
    }

    public IBook Build()
    {
        return comic;
    }
}