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
      UpdateBookManager updateBookManager = new UpdateBookHandler();
      
      IFacade facadeFroCreateBook = new FacadeFroCreateBook(director, validator, manager);
      IFacade facadeForUpdateBook = new FacedeForUpdateBook(validator, manager, updateBookManager, facadeFroCreateBook);
      ManageStrategy manageStrategy = new UpdateBookInList();
      manageStrategy.Read();
      IBook book = facadeForUpdateBook.Execute();
      manageStrategy.Manage(book);
      manageStrategy.Read();
   }
}