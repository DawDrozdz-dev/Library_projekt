using Library.BookManager;
using Library.UserInterFaceExecutor;
using Library.Validators;

namespace Library.UserInterfaceExecutors;
 
public class FacadeFroRemoveBook : IFacade
{
    private readonly IBookBuilder _builder;
    private readonly IDataConverter _converter;
    private readonly IDataManager _dataManager;

    public FacadeFroRemoveBook(IBookBuilder builder, IDataManager dataManager, IDataConverter converter)
    {
        _builder = builder;
        _dataManager = dataManager;
        _converter = converter;
    }
    public IBook Execute()
    {
        Console.WriteLine("\nPodaj ID dla książki którą chcesz usunąć (liczba rzeczywista): ");
        var dataForId = _dataManager.GetData();
        var validatedData = _converter.ConvertInt(dataForId);
        
        _builder.SetId(validatedData);
        IBook book = _builder.Build();
        return book;
    }
}