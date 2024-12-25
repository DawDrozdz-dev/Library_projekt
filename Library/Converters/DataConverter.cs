namespace Library.Validators;

public class DataConverter : IDataConverter
{
    public string ConvertString(string value)
    {
        if (string.IsNullOrEmpty(value) || value.Length > 30)
        {
            Console.WriteLine("Invalid data, it cant be null or less than 30 characters.");
            return "-";
        }
        return value;
    }

    public int ConvertInt(string value)
    {
        if (!int.TryParse(value, out int result))
        {
            Console.WriteLine("Invalid data, can't parse it");
            return 0;
        }
        return result;
    }

    public double ConvertDouble(string value)
    {
        if (!double.TryParse(value, out double result))
        {
            Console.WriteLine("Invalid data, can't parse it");
            return 0;
        }
        return result;
    }
}