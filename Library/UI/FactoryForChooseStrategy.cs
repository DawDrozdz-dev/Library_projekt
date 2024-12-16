using Library.UserInterFaceExecutor;
using Library.UserInterfaceExecutors;
using Library.Validators;

namespace Library.BookManager;

public class FactoryForChooseStrategy
{
    // Pole statyczne przechowujące jedyną instancję klasy
    private static readonly Lazy<FactoryForChooseStrategy> _instance =
        new Lazy<FactoryForChooseStrategy>(() => new FactoryForChooseStrategy());

    // Prywatny konstruktor, aby zapobiec tworzeniu instancji z zewnątrz
    private FactoryForChooseStrategy() { }

    // Publiczna właściwość zapewniająca dostęp do jedynej instancji
    public static FactoryForChooseStrategy Instance => _instance.Value;

    // Metoda tworząca konteksty na podstawie parametru "type"
    public IContext CreateContext(string type)
    {
        switch (type)
        {
            case "1":
                return new ContextForExecuteFacade(
                    new FacadeForCreateBook(new Director(new BookBuilder()), new DataValidatorForCreateBook(), new GetStringValue()),
                    new AddBookToList());

            case "2":
                return new ContextForExecuteFacade(
                    new FacadeForReadBook(),
                    null
                );

            case "3":
                return new ContextForExecuteFacade(
                    new FacadeFroRemoveBook(new BookBuilder(), new GetStringValue(), new DataValidatorForCreateBook()),
                    new RemoveBookFromList()
                );

            case "4":
                return new ContextForExecuteFacade(
                    new FacedeForUpdateBook(
                        new DataValidatorForCreateBook(),
                        new GetStringValue(),
                        new UpdateBookManager(),
                        new FacadeForCreateBook(new Director(new BookBuilder()), new DataValidatorForCreateBook(), new GetStringValue())),
                    new UpdateBookInList()
                );

            default:
                throw new ArgumentException("Invalid operation type.");
        }
    }
}
