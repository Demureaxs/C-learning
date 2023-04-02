// See https://aka.ms/new-console-template for more information

using System;
using System.ComponentModel;
using System.Threading.Channels;
using System.Linq;
using ConsoleApp1.Dates_and_time;
using ConsoleApp1.Math;
using ConsoleApp1.Section_4_Arrays;
using ConsoleApp1.WorkingWithFiles;

namespace ConsoleApp1;

public class numberMachine
{
    private string userInput;

    public void UnlockTheForce()
    {
        Console.Write($"Please input any amount of numbers seperated by a comma: ");
        userInput = Console.ReadLine();

        int[] parsedNumbers;

        try
        {
            parsedNumbers = userInput.Split(',').Select(int.Parse).ToArray();
        }
        catch (FormatException)
        {
            Console.WriteLine($"Invalid input format, Please enter numbers seperated by commas");
            return;
        }

        var sum = parsedNumbers.Sum();
        Console.WriteLine($"The sum of your numbers is {sum}");
    }
}

public static class Program
{
    private static void Main(string[] args)
    {
        // Console.WriteLine($"---------------------Program 1--------------------");
        // var divideByX = new DivisibleByX();
        // divideByX.ReturnResults();

        // Console.WriteLine($"---------------------Program 2--------------------");
        // var requireAnswers = new DemandAnswers();
        // requireAnswers.GetThoseAnswersBitch();

        // Console.WriteLine($"---------------------Program 3--------------------");
        // var factorialMachine = new ComputeFactorial();
        // factorialMachine.GetTheFactors();

        // Console.WriteLine($"---------------------Program 4--------------------");
        // var numberGame = new NumberGame();
        // numberGame.PlayGame();

        // Console.WriteLine($"---------------------Program 5--------------------");
        // var addNumbers = new numberMachine();
        // addNumbers.UnlockTheForce();

        // Console.WriteLine($"---------------------Program 6--------------------");
        // Arrays1.Application();

        // Console.WriteLine($"---------------------Program 7--------------------");
        // DatesAndTimes.Application();

        // Console.WriteLine($"---------------------Program 8--------------------");
        // Strings1.Application();
        
        Console.WriteLine($"---------------------Program 9--------------------");
        FilesAndDirectories.app();
    }
}

// 604 lines up to dates and times -- continue the count after