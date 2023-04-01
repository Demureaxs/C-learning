using System.Text;

namespace ConsoleApp1;

public class PascalMe
{
    public static void PascalMeNow()
    {
        // using linq functions
        Console.Write($"Enter a series of words to begin creating your pascal variable name: ");
        var input = Console.ReadLine();
        string output = string.Join("",input.ToLower().Split(" ").Select(word => char.ToUpper(word[0]) + word.Substring(1).ToLower()));

        // using stringBuilder
        var outputBuilder = new StringBuilder();
        foreach (var word in input.ToLower().Split(" "))
        {
            outputBuilder.Append(char.ToUpper(word[0]) + word.Substring(1));
        }

        Console.WriteLine(outputBuilder.ToString());
        Console.WriteLine(output);
    }
}