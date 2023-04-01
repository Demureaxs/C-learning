namespace ConsoleApp1;

public class DivisibleByX
{
    private int numbers { get; set; }
    private int divisor { get; set; }
    private int count { get; set; }

    private void GetNumbers()
    {
        Console.Write($"Please enter the maximum number: ");
        numbers = int.Parse(Console.ReadLine());
    }

    private void GetDivisor()
    {
        Console.Write($"Please enter your desired divisor?: ");
        divisor = int.Parse(Console.ReadLine());
    }

    public void ReturnResults()
    {
        GetNumbers();
        GetDivisor();

        for (var i = 1; i < numbers; i++)
            if (i % divisor == 0)
                count++;

        Console.WriteLine($"There are {count} numbers divisible by {divisor} between 0 and {numbers}");
    }
}