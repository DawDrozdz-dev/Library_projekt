namespace Library.UserInterFaceExecutor;
using Library.BookManager;

public interface IDirector
{
    public IBook BuildBook(string author, string title, string description, double price, int bookId);
}