namespace ConsoleApp1;

public class SpeedCamera
{
    private int speedLimit;
    private int CarSpeed;
    private int PenaltyPoints;

    private void SetSpeedLimit()
    {
        Console.WriteLine($"Please Enter your speed limit");
        speedLimit = int.Parse(Console.ReadLine());
    }

    private void GetCarSpeed()
    {
        Console.WriteLine($"What speed is the car travelling at");
        CarSpeed = int.Parse(Console.ReadLine());
    }

    private void calculatePoints()
    {
        PenaltyPoints = CarSpeed > speedLimit ? (CarSpeed - speedLimit) / 5 : 0;
        Console.WriteLine(PenaltyPoints);
    }

    private void issueJudgement()
    {
        var result = PenaltyPoints is > 0 and <= 12 ? $"You have incurred {PenaltyPoints} Penalty Points" :
            PenaltyPoints > 12 ? $"License Suspended" : $"Ok";
        Console.WriteLine(result);
    }
    public void Activate()
    {
        SetSpeedLimit();
        GetCarSpeed();
        calculatePoints();
        issueJudgement();
    }

}