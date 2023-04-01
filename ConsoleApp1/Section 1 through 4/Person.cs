namespace ConsoleApp1;

public class Person
{
    public string FirstName;
    public string LastName;

    public string name => $"{FirstName} {LastName}";

    private static int[] numbers = new int[3] { 1, 2, 3 };

    private string list = string.Join(" Wanker ", numbers);

    private char firstLetter => FirstName[2];

    public static void SaySomethingRude()
    {
        Console.WriteLine($"Hello you massive cunt. My name is Martyn and I suck balls");
    }

    public void Introduce()
    {
        Console.WriteLine($"My name is {FirstName} {LastName}");

        Console.WriteLine(list);

        Console.WriteLine(firstLetter);

        SaySomethingRude();
    }
}