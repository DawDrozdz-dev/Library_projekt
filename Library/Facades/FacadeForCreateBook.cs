using Library.BookManager;
using Library.UserInterFaceExecutor;
using Library.Validators;

namespace Library.UserInterfaceExecutors;

public class FacadeForCreateBook : IFacade
{
   private static NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();
   private readonly IDirector _director;
   private readonly IDataConverter _converter;
   private readonly IDataManager _dataManager;

   public FacadeForCreateBook(IDirector director, IDataConverter converter, IDataManager dataManager)
   {
      _director = director;
      _converter = converter;
      _dataManager = dataManager;
   }

   public IBook Execute()
   {
      Console.WriteLine("Wpisz tytul ksiazki: ");
      var dataForTitle = _dataManager.GetData();
      Console.WriteLine("\nWpisz autora ksiazki: ");
      var dataForAuthor = _dataManager.GetData();
      Console.WriteLine("\nDodaj opis: ");
      var dataForDescription = _dataManager.GetData();
      Console.WriteLine("\nDodaj cene za ksiazke (liczba zmienno-przecinkowa: ");
      var dataForPrice = _dataManager.GetData();
      Console.WriteLine("\nNadaj ID dla książki (liczba rzeczywista): ");
      var dataForId = _dataManager.GetData();
      
      var validationForTitle = _converter.ConvertString(dataForTitle);
      var validationForAuthor = _converter.ConvertString(dataForAuthor);
      var validationForDescription = _converter.ConvertString(dataForDescription);
      var validationForPrice = _converter.ConvertDouble(dataForPrice);
      var validationForId = _converter.ConvertInt(dataForId);
      
      var book = _director.BuildBook(validationForAuthor, validationForTitle, validationForDescription, 
         validationForPrice, validationForId);
      _logger.Info($"\n The library data has been changed by:" +
                   $"\n Book title; {book.Title}\n " +
                   $"Author; {book.Author}\n " +
                   $"Price; {book.Price}\n " +
                   $"Description; {book.Description}\n" +
                   $"ID: {book.Id}\n");
      return book;
   }
}