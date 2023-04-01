namespace ConsoleApp1;

public class CheckForDuplicates
{
    public static void GetNumbers()
    {
        Console.WriteLine($"Please enter hyphen seperated numbers or press enter to exit");
        var input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input)) return;

        HashSet<int> characterSet = new HashSet<int>(input.Split('-').Select(int.Parse));

        var duplicate = input.Split('-').Length != characterSet.Count ? "Duplicate" : null;
        
        Console.WriteLine(duplicate);
    }
}