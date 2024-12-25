using System.Diagnostics;
using Library.BookBase;
using Library.BookManager;
using Library.UserInterFaceExecutor;
using Library.UserInterfaceExecutors;
using Library.Validators;
using NLog.Fluent;
using System.Threading;
namespace Library.Program;

public class Program
{
    private static NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

    public static void Main(string[] args)
    {
        Console.WriteLine(
            "Witaj w aplikacji 'moja biblioteka', wybierz, co chcesz zrobić: \n");
        Thread.Sleep(2000);
        while (true)
        {
            Console.WriteLine(
                "Wpisz 1 - aby stworzyć książkę.\nWpisz 2 - aby wyswietlić książki.\nWpisz 3 - aby usunąć książkę.\n" +
                "Wpisz 4 - aby edytować książkę.\n " +
                "Wpisz 5 - aby wyjsc");
            try
            {
                string data = Console.ReadLine();
                IIntConverter converter = new ValidationForFactory();
                int value = converter.ConvertInt(data);

                if (value == 5)
                {
                    break; 
                }

                var factoryForChoose = new FactoryForChooseStrategy();
                var strategy = factoryForChoose.CreateContext(value);
                strategy.Manage();
                Thread.Sleep(4000);
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
                Console.WriteLine("Wcisnij 'enter' aby kontynuować");
                Console.ReadKey();
            }
        }

        Console.WriteLine("Dziekuje za uzycie aplikacji.\n\n");
    }
}
   