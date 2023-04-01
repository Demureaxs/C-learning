namespace ConsoleApp1.Section_4_Arrays;

public class NameReverser
{
    private string name;

    private void GetName()
    {
        Console.Write($"Please enter your name to continue: ");
        name = Console.ReadLine();
    }

    public void ReverseName()
    {
        GetName();
        var reverseName = string.Join("", name.ToCharArray().Reverse());
        Console.WriteLine(reverseName);
    }
}