using Library.BookManager;
namespace Library.BookBase;
public class BaseOfBook
{
    private static BaseOfBook _instance = null;
    private static readonly object _obj = new object();

    // Trwała lista książek
    public static List<IBook> books { get; } = new List<IBook>() {
        new Comic()
    {
        Title = "test", Author = "test", Id = 1, Description = "test", Price = 19.11,
        
    },
        new Comic() 
        {
        Title = "test", Author = "test", Id = 22, Description = "test", Price = 19.11,       
    }
    };

    private BaseOfBook() { }

    public static BaseOfBook GetInstance()
    {
        lock (_obj)
        {
            if (_instance == null)
            {
                _instance = new BaseOfBook();
            }
        }

        return _instance;
    }
}