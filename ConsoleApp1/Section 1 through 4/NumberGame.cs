namespace ConsoleApp1;

public class NumberGame
{
    private readonly int _random = new Random().Next(1, 10);
    private int setDifficulty;

    private void GetDifficulty()
    {
        Console.WriteLine(_random);
        Console.Write($"Please type your desired difficulty, enter either easy medium or hard: ");
        var input = Console.ReadLine();

        switch (input.ToLower())
        {
            case "easy":
                setDifficulty = (int)Difficulty.easy;
                break;
            case "medium":
                setDifficulty = (int)Difficulty.medium;
                break;
            case "hard":
                setDifficulty = (int)Difficulty.hard;
                break;
            default:
                Console.WriteLine($"Not a valid difficulty");
                break;
        }
    }

    public void PlayGame()
    {
        GetDifficulty();
        var isWinner = false;
        for (var i = setDifficulty; i >= 1; i--)
        {
            Console.WriteLine($"You have {i} guess{(i > 1 ? "es" : null)}, what is my secret number?");
            var input = int.Parse(Console.ReadLine());

            if (input == _random)
            {
                Console.WriteLine($"You win with the correct guess of {input}");
                isWinner = true;
                break;
            }
            else
            {
                Console.WriteLine($"Incorrect");
            }
        }
        if(!isWinner) Console.WriteLine($"Better luck next time!!!");
    }
}