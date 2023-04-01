using System.Numerics;

namespace ConsoleApp1;

public class ComputeFactorial
{
    private int startingNumber;

    private void GetNumber()
    {
        var hasEnteredNumber = false;

        while (!hasEnteredNumber)
        {
            Console.Write($"Please enter a starting number for your factorial: ");
            var input = Console.ReadLine();

            if (!int.TryParse(input, out var num)) continue;
            startingNumber = num;
            hasEnteredNumber = true;
        }
    }

    private void ReturnFactorial()
    {
        var temporary = new List<BigInteger>();
        for (var i = startingNumber; i > 0; i--) temporary.Add(i);

        var result = temporary.Aggregate(BigInteger.One, (total, number) => total * number);
        Console.WriteLine($"{startingNumber}! = {result.ToString()}");
    }

    public static void PrintISuck() 
    {
        
    }

    public void GetTheFactors()
    {
        GetNumber();
        ReturnFactorial();
    }
}