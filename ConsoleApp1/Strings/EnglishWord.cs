namespace ConsoleApp1;

public class EnglishWord
{
    
    public static void VowelCounter()
    {
        const string vowels = "aeiouAEIOU";
        
        Console.Write($"Enter any Word in english to find the number of vowels: ");
        var input = Console.ReadLine();

        // we have to remember this one, really useful
        var count = input.Count(t => vowels.Contains(t));

        Console.WriteLine($"Your word contains {count} vowels");
    }
}