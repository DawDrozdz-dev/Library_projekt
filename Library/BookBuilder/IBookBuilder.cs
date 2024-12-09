using Library.BookManager;

namespace Library.UserInterFaceExecutor;

public interface IBookBuilder
{
    void SetTitle(string title);
    void SetAuthor(string author);
    void SetDescription(string description);
    void SetPrice(double price);
    void SetId(int id);
    IBook Build();
    
}