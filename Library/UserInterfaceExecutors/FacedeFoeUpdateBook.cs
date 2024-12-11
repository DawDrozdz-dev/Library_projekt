using Library.BookManager;
using Library.Validators;
using System;
using Library.UserInterFaceExecutor;

namespace Library.UserInterfaceExecutors;

public class FacedeForUpdateBook : IFacade
{
    private readonly IDataValidator _validator;
    private readonly IDataManager _dataManager;
    private readonly UpdateBookManager _updateBookManager;
    private readonly IFacade _facade;

    public FacedeForUpdateBook(IDataValidator validator, IDataManager dataManager, UpdateBookManager updateBookManager,
        IFacade facade)
    {
        _validator = validator;
        _dataManager = dataManager;
        _updateBookManager = updateBookManager;
        _facade = facade;
    }
    
    public IBook Execute()
    {
        Console.WriteLine("\nPodaj Id ksiązki, ktora chcesz edytować (liczba rzeczywista): ");
        var dataForId = _dataManager.GetData();
        var validationForId = _validator.ValidateInt(dataForId);
        bool isSuccess = _updateBookManager.GetBook(validationForId);
        
        if (isSuccess == false)
        {
            Console.WriteLine("There is no book with the given id.");
        }
        IBook book = _facade.Execute();
        book.Id = validationForId;
        return book;
    }
}