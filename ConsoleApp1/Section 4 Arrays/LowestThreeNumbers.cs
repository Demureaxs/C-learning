namespace ConsoleApp1.Section_4_Arrays;

public class LowestThreeNumbers
{
    

    public static void AskForNumbers()
    {
        Console.WriteLine($"Please enter 5 comma seperated numbers to continue");
        var input = Console.ReadLine();
        var numbers = input.Split(',').Select(int.Parse).ToArray();

        while (numbers.Length < 5)
        {
            Console.WriteLine($"Invalid list, Please enter 5 comma-seperated numbers:");
            input = Console.ReadLine();
            numbers = input.Split(',').Select(int.Parse).ToArray();
        }
        // sort the array
        Array.Sort(numbers);
        Console.WriteLine($"The lowest 3 numbers you entered are: {string.Join(", ", numbers.Take(3).ToArray())}");
        
        // // create an empty array for the slice
        // var slicedNums = new int[3];
        //
        // // copy the first 3 elements of 
        // Array.Copy(numbers, slicedNums, 3);
        //
        // // output the lowest 3 numbers in a string
        // Console.WriteLine($"The lowest three numbers you entered are: {string.Join(", ", slicedNums)}");
    }
}