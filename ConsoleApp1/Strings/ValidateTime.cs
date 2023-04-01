using System.Globalization;

namespace ConsoleApp1;

public class ValidateTime
{
    public static void getAndValidate()
    {
        Console.WriteLine($"Please enter a time seperated by a colon in 24 hour time format");
        var input = Console.ReadLine();

        if (DateTime.TryParseExact(input, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
        {
            Console.WriteLine($"Ok");
        }
        else
        {
            Console.WriteLine($"Invalid time inserted");
        }

    }
}