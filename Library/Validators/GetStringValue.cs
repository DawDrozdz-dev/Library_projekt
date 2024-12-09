namespace Library.UserInterFaceExecutor;

public class GetStringValue : IDataManager
{
    public string? GetData()
    {
        string? value = Console.ReadLine();
        return value;
    }
}