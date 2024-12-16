using Library.UserInterFaceExecutor;

namespace Library.Validators;

public class ValidationForFactory : IStringValidator
{
    public string ValidateString(string value)
    {
        if (value == "1" || value == "2" || value == "3" || value == "4" || value == "5")
        {
            return value; 
        }
        throw new ArgumentException($"{value} is invalid.");
    }
}

