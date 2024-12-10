using Library.BookManager;
using Library.UserInterFaceExecutor;
using Library.UserInterfaceExecutors;
using Library.Validators;

namespace Library.Program;

public class Program
{
   static void Main(string[] args)
   {
      
      IDataValidator validator = new DataValidatorForCreateBook();
      IBookBuilder bookBuilder = new BookBuilder();
      IDirector director = new Director(bookBuilder);
      IDataManager manager = new GetStringValue();
      FacadeFroCreateBook facadeFroCreateBook = new FacadeFroCreateBook(director, validator, manager);
      var book = facadeFroCreateBook.Execute();
      Console.WriteLine(book);
   }
}