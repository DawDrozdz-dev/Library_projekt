using Library.UserInterfaceExecutors;

namespace Library.BookManager;

public class ContextForExecuteFacade : IContext
{
    private readonly IFacade _facade;
    private readonly IManageStrategy? _strategy;

    public ContextForExecuteFacade(IFacade facade, IManageStrategy? strategy)
    {
        _facade = facade;
        _strategy = strategy;
    }

    public void Manage()
    {

        var book = _facade.Execute();
        _strategy.Manage(book);
       
        // Tutaj będzie implementacja wczytania operacji do pliku 
    }
}