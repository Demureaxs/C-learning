namespace ConsoleApp1.Section_4_Arrays;

public class fbPostLiker
{
    private List<string> whoLikesIt = new();
    private bool finished = false;
    private string finalOutput;

    private void GetNames()
    {
        while (!finished)
        {
            Console.WriteLine($"Please enter a name to continue or hit enter to finish");
            var input = Console.ReadLine();
            if (input.Length == 0)
            {
                finished = true;
                break;
            }
            else
            {
                whoLikesIt.Add(input);
            }
        }
    }

    private void FormatResults()
    {
        if (whoLikesIt.Count == 0)
        {
            Console.WriteLine($"No one likes it you sad looser!");
        }
        else if (whoLikesIt.Count == 1)
        {
            Console.WriteLine($"{whoLikesIt[0]} likes your post.");
        }
        else if (whoLikesIt.Count == 2)
        {
            Console.WriteLine($"{whoLikesIt[0]} and {whoLikesIt[1]} like your post");
        }
        else
        {
            Console.WriteLine($"{whoLikesIt[0]}, {whoLikesIt[1]} and {whoLikesIt.Count - 2} others like your post.");
        }
    }

    public void StartLikeMachine()
    {
        GetNames();
        FormatResults();
    }
}