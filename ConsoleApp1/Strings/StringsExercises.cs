using System.Globalization;

namespace ConsoleApp1;

public static class StringsExercises
{
    private static string fullName = "Martyn Clarke ";

    public static void App()
    {
        Console.WriteLine($"Trim: '{fullName.Trim()}'");
        Console.WriteLine($"Trim: '{fullName.Trim().ToUpper()}'");

        var index = fullName.IndexOf(' ');
        var firstName = fullName.Substring(0, index);
        var lastName = fullName.Substring(index + 1);

        Console.WriteLine($"First name: {firstName}");
        Console.WriteLine($"Last name: {lastName}");

        var names = fullName.Split(' ');
        Console.WriteLine($"First Name: {names[0]}");
        Console.WriteLine($"First Name: {names[1]}");

        var newName = fullName.Replace("Martyn", "Bellend");
        var editedNewName = fullName.Replace('a', 'A');

        Console.WriteLine(newName);
        Console.WriteLine(editedNewName);
        
        // for string validation, Trim is one method to check that something valid is entered
        if(String.IsNullOrWhiteSpace(" "))
            Console.WriteLine("Invalid");

        var str = "25";
        var byteStr = Convert.ToByte(str);

        Console.WriteLine(byteStr);

        float price = 29.95f;
        // formats the price with Currency to 2 decimal places 
        // culture info.createSpecificCulture is to select the currency
        // (C0) no decimal places (C2) 2 decimal places
        var formatPrice = price.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"));

        Console.WriteLine($"The price is: {formatPrice}");
    }
}