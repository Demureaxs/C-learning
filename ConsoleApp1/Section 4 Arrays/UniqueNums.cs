namespace ConsoleApp1.Section_4_Arrays;

public class UniqueNums
{
    private List<int> numberList = new();
    private bool isFinished = false;

    public void getNumbers()
    {
        while (!isFinished)
        {
            Console.WriteLine($"Please enter a number to continue or type quit to exit");
            var input = Console.ReadLine();
            if (input.ToLower() == "quit") break;
            if (!int.TryParse(input, out var num))
                Console.WriteLine($"Please only enter numbers or 'quit'!");
            else
                numberList.Add(num);
        }

        var uniqueNums = new HashSet<int>(numberList);
        Console.WriteLine($"Your unique numbers are: {string.Join(", ", uniqueNums)}");
    }
}