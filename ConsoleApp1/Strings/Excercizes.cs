namespace ConsoleApp1;

public class IsConsecutive
{
    public static void CheckIfConsec()
    {
        var isConsec = true;
        
        Console.Write($"Please enter a few numbers seperated by a hyphen: ");
        var input = Console.ReadLine().Split('-').Select(int.Parse).ToArray();

        for (var i = 0; i < input.Length - 1; i++)
        {
            if (input[i + 1] == input[i] + 1 || input[i + 1] == input[i] - 1)
            {
                continue;
            }
            else
            {
                isConsec = false;
            }

        }
        var answer = isConsec ? "Consecutive" : "Not Consecutive";
        Console.WriteLine(answer);
        
        
    }
}

public class Excercizes
{
    public static void app()
    {
        Console.WriteLine($"-----------Exercise 1---------");
        IsConsecutive.CheckIfConsec();
    }
}