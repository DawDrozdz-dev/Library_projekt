namespace Library.UserInterFaceExecutor;

public class DataValidator : IStringValidator, IDoubleValidator, IIntValidator
{
    public string ValidateString(string value)
    {
        if (string.IsNullOrEmpty(value) || value.Length > 30)
        {
            Console.WriteLine("Invalid data, it cant be null or less than 30 characters.");
        }
        return value;
    }

    public int ValidateInt(string value)
    {
        if (!int.TryParse(value, out int result))
        {
            Console.WriteLine("Invalid data, can't parse it");
        }
        return result;
    }

    public double ValidateDouble(string value)
    {
        if (!double.TryParse(value, out double result))
        {
            Console.WriteLine("Invalid data, can't parse it");
        }
        return result;
    }
}