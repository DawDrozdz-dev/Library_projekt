using Library.Validators;

namespace Library.UserInterFaceExecutor;
using Library.BookManager;
public class Facade
{
   private readonly IDirector _director;
   private readonly IDataValidator _validator;
   private readonly IDataManager _dataManager;

   public Facade(IDirector director, IDataValidator validator, IDataManager dataManager)
   {
      _director = director;
      _validator = validator;
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
      
      var validationForTitle = _validator.ValidateString(dataForTitle);
      var validationForAuthor = _validator.ValidateString(dataForAuthor);
      var validationForDescription = _validator.ValidateString(dataForDescription);
      var validationForPrice = _validator.ValidateDouble(dataForPrice);
      var validationForId = _validator.ValidateInt(dataForId);
      
      var book = _director.BuildBook(validationForTitle, validationForAuthor, validationForDescription, 
         validationForPrice, validationForId);
      return book;
   }
}