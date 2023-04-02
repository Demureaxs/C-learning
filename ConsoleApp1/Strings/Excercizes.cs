namespace ConsoleApp1;

public abstract class Excercizes
{
    public static void app()
    {
        Console.WriteLine($"-----------Exercise 1---------");
        // IsConsecutive.CheckIfConsec();

        Console.WriteLine($"-----------Exercise 2---------");

        // CheckForDuplicates.GetNumbers();
        Console.WriteLine($"-----------Exercise 3---------");
        // ValidateTime.getAndValidate();

        Console.WriteLine($"-----------Exercise 4---------");
        // PascalMe.PascalMeNow();

        Console.WriteLine($"-----------Exercise 4---------");
        // EnglishWord.VowelCounter();

        Console.WriteLine($"-----------Procedural Programming example--------------");
        Console.Write("Whats your name? ");
        var name = Console.ReadLine();

        var reversed = ReverseName(name);

        Console.WriteLine($"Reversed Name: {reversed}");


        Console.WriteLine($"-----------Procedural Programming example 2--------------");
        var numbers = new List<int>();

        while (true)
        {
            Console.Write($"Enter a number (or 'quit' to exit): ");
            var input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;
            
            numbers.Add(Convert.ToInt32(input));
        }

        var uniques = GetUniqueNumbers(numbers);
        Console.WriteLine(uniques);
    }

    private static string ReverseName(string name)
    {
        var array = new char[name.Length];
        for (var i = name.Length - 1; i >= 0; i--)
            array[name.Length - i - 1] = name[i];

        return new string(array);
    }
    
    

    public static List<int> GetUniqueNumbers(List<int> numbers)
    {
        var uniques = new List<int>();
        foreach (var number in numbers)
        {
            if (!uniques.Contains(number))
                uniques.Add(number);
        }
        
        
        Console.WriteLine($"Unique numbers: ");
        foreach (var number in uniques)
        {
            Console.Write($"{number}, ");
        }

        return uniques;
    }
}