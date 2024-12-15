using System.Diagnostics;
using Library.BookBase;
using Library.BookManager;
using Library.UserInterFaceExecutor;
using Library.UserInterfaceExecutors;
using Library.Validators;

namespace Library.Program;

public class Program
{
   static void Main(string[] args)
   {
      BaseOfBook.GetInstance();
      IDataValidator validator = new DataValidatorForCreateBook();
      IBookBuilder bookBuilder = new BookBuilder();
      IBookBuilder bookBuilder2 = new BookBuilder();
      IDirector director = new Director(bookBuilder);
      IDirector director2 = new Director(bookBuilder2);
      IDataManager manager = new GetStringValue();
      ITakeBookFromList take = new UpdateBookManager();
      
   
      IManageStrategy strategy = new AddBookToList();
      IManageStrategy strategy2 = new RemoveBookFromList();
      IManageStrategy strategy3 = new UpdateBookInList();
      
      IFacade facadeFroCreateBook = new FacadeForCreateBook(director, validator, manager);
      IFacade facadeFroCreateBook2 = new FacadeForCreateBook(director2, validator, manager);
      IFacade facadeForRemoveBook = new FacadeFroRemoveBook(bookBuilder, manager, validator);
      IFacade facadeForUpdateBook = new FacedeForUpdateBook(validator, manager, take, facadeFroCreateBook);
      var x = facadeFroCreateBook.Execute();
      var y = facadeFroCreateBook2.Execute();
     
      strategy.Manage(x);
      strategy.Manage(y);
      
      foreach (var item in BaseOfBook.books)
      {
         Console.WriteLine(item);
      }
      var a = facadeForRemoveBook.Execute();
      strategy2.Manage(a);
      foreach (var item in BaseOfBook.books)
      {
         Console.WriteLine(item);
      }
      var b = facadeForUpdateBook.Execute();
      strategy3.Manage(b);
      foreach (var item in BaseOfBook.books)
      {
         Console.WriteLine(item);
      }
   }
}