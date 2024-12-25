using System.Diagnostics;
using Library.BookBase;
using Library.BookManager;
using Library.UserInterFaceExecutor;
using Library.UserInterfaceExecutors;
using Library.Validators;
using NLog.Fluent;

namespace Library.Program;

public class Program
{
    private static NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();
   public static void Main(string[] args)
   {
      while (true)
      {
          try
          {

              Console.WriteLine(
                  " Wpisz 1 - aby stworzyć książkę, 2 - aby wyswietlić książki, 3 - aby usunąć książkę, 4 - aby edytować książkę");
              string data = Console.ReadLine();

              IStringConverter converter = new ValidationForFactory();
              string stringValue = converter.ConvertString(data);
              var factoryForChoose = new FactoryForChooseStrategy();
              var strategy = factoryForChoose.CreateContext(stringValue);
              strategy.Manage();
          }
          catch (ArgumentException ex)
          {
              Console.WriteLine($"Błąd: {ex.Message}");
              _logger.Error($"Błąd: {ex.Message}");
          }
          catch (Exception ex)
          {
              Console.WriteLine($"Błąd: {ex.Message}");
              _logger.Error($"Błąd: {ex.Message}");
          }
      }
     
   

   }
}