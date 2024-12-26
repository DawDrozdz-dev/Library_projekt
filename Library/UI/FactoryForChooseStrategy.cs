using Library.UserInterFaceExecutor;
using Library.UserInterfaceExecutors;
using Library.Validators;

namespace Library.BookManager;

public class FactoryForChooseStrategy
{
    public IContext CreateContext(int type)
    {
        switch (type)
        {
            case 1:
                return new ContextForExecuteFacade(
                    new FacadeForCreateBook(new Director(new BookBuilder()), new DataConverter(), new GetStringValue()),
                    new AddBookToList());

            case 2:
                return new ContextForExecuteFacade(
                    new FacadeForReadBook(),
                    new NullStrategy()
                );

            case 3:
                return new ContextForExecuteFacade(
                    new FacadeFroRemoveBook(new BookBuilder(), new GetStringValue(), new DataConverter()),
                    new RemoveBookFromList()
                );

            case 4:
                return new ContextForExecuteFacade(
                    new FacedeForUpdateBook(
                        new DataConverter(),
                        new GetStringValue(),
                        new TakeBookFromList(),
                        new FacadeForCreateBook(new Director(new BookBuilder()), new DataConverter(), new GetStringValue())),
                    new UpdateBookInList()
                );
            default:
                Console.WriteLine("Nieznany typ operacji. Wybierz poprawny.");
                return null;
        }
    }
}
