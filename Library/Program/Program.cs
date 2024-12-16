using System.Diagnostics;
using Library.BookBase;
using Library.BookManager;
using Library.UserInterFaceExecutor;
using Library.UserInterfaceExecutors;
using Library.Validators;

namespace Library.Program;

public class Program
{
   public static void Main(string[] args)
   {
      Console.WriteLine("wpisz 1 - tworzenie, 2- wyswietlenie listy, 3 - usuwanie, 4 - edycja");
      string x = Console.ReadLine();
      IStringValidator validator = new ValidationForFactory();
      string y = validator.ValidateString(x);

      var sx = FactoryForChooseStrategy.Instance.CreateContext(y);
      sx.Manage();

   }
}