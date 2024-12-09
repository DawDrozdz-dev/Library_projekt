using Library.BookManager;
using Library.UserInterFaceExecutor;
namespace Library.Program;

public class Program
{
   static void Main(string[] args)
   {
      
      DataValidator validator = new DataValidator();
      IBookBuilder bookBuilder = new BookBuilder();
      IDirector director = new Director(bookBuilder);
      IDataManager manager = new GetStringValue();
      Facade facade = new Facade(director, validator, manager);
      var book = facade.Execute();
      Console.WriteLine(book);
   }
}