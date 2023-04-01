namespace ConsoleApp1;

public class DemandAnswers
{
    private int count;
    private string input;
    private readonly List<int> _numbers = new();
    private bool finished = false;

    private void PromptForInput()
    {
        Console.Write($"Please enter a number to continue or 'ok' to finish: ");
        input = Console.ReadLine();
    
    }

    private void CheckOkStatus()
    {
        if (input.ToLower() == "ok")
            finished = true;
        else if (int.TryParse(input, out var num))
            _numbers.Add(num);
        else
            Console.WriteLine($"invalid input, only numbers to continue or ok to finish please: ");
    }

    public void GetMeTheFingerBanger()
    {
        Console.WriteLine($"I dont care what people say, I just want to easy");
        var input = Console.ReadLine();
    }

    public void GetThoseAnswersBitch()
    {
        while (!finished)
        {
            PromptForInput();
            CheckOkStatus();
        }

        
        var numbersArray = _numbers.ToArray();
        var sum = Enumerable.Sum(numbersArray);
        Console.WriteLine($"The sum of the numbers you entered is {sum}");
    }
}

