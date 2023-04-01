namespace ConsoleApp1.Section_4_Arrays;

public class NumberSorter
{
    private int inputQuantity;
    private List<int> _numberList = new();

    private void GetGameLength()
    {
        Console.WriteLine($"Ok We are going to play a game, Input a number between 1 and 10");
        var input = Console.ReadLine();
        while (!int.TryParse(input, out var num))
        {
            Console.WriteLine($"Not a valid number, please try again");
            input = Console.ReadLine();
        }

        inputQuantity = int.Parse(input);
    }

    private void GetNumbers()
    {
        for (var i = 0; i < inputQuantity; i++)
        {
            Console.WriteLine($"Enter Unique Number: {i + 1}");
            var input = Console.ReadLine();
            while (!int.TryParse(input, out var num) || _numberList.Contains(int.Parse(input)))
            {
                Console.WriteLine($"invalid input, please enter unique numbers only");
                input = Console.ReadLine();
            }

            _numberList.Add(int.Parse(input));
        }
    }

    private void SortTheNumbers()
    {
        _numberList.Sort();
        Console.WriteLine(string.Join(", ", _numberList));
    }

    public void play()
    {
        GetGameLength();
        GetNumbers();
        SortTheNumbers();
    }
}