using Library.UserInterFaceExecutor;

namespace Library.Validators;

public class ValidationForFactory : IStringConverter
{
    public string ConvertString(string value)
    {
        if (value == "1" || value == "2" || value == "3" || value == "4")
        {
            return value; 
        }
        throw new ArgumentException($"{value} is invalid.");
    }
}

