using Library.UserInterFaceExecutor;

namespace Library.Validators;

public class ValidationForFactory : IIntConverter
{
    public int ConvertInt(string value)
    {
        if (value == "1" || value == "2" || value == "3" || value == "4" || value == "5")
        {
            int data = Convert.ToInt16(value);
            return data; 
        }
        throw new ArgumentException($"{value} is invalid.");
    }
}

