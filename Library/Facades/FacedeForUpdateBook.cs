using Library.BookManager;
using Library.Validators;
using System;
using Library.UserInterFaceExecutor;

namespace Library.UserInterfaceExecutors;

public class FacedeForUpdateBook : IFacade
{
    private readonly IDataConverter _converter;
    private readonly IDataManager _dataManager;
    private readonly ITakeBookFromList _updateBookManager;
    private readonly IFacade _facade;

    public FacedeForUpdateBook(IDataConverter converter, IDataManager dataManager, ITakeBookFromList updateBookManager,
        IFacade facade)
    {
        _converter = converter;
        _dataManager = dataManager;
        _updateBookManager = updateBookManager;
        _facade = facade;
    }
    
    public IBook Execute()
    {
        Console.WriteLine("\nPodaj Id ksiązki, ktora chcesz edytować (liczba rzeczywista): ");
        var dataForId = _dataManager.GetData();
        var validationForId = _converter.ConvertInt(dataForId);
        bool isSuccess = _updateBookManager.GetBook(validationForId);
        
        if (isSuccess == false)
        {
            Console.WriteLine("There is no book with the given id.");
            throw new Exception("Operation aborted: invalid book ID.");
        }
        IBook book = _facade.Execute();
        book.Id = validationForId;
        return book;
    }
}