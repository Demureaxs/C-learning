namespace ConsoleApp1.Dates_and_time;

public static class DatesAndTimes
{
    public static void Application()
    {
        
        // date time object
        var dateTime = new DateTime(2015, 1, 1);
        var now = DateTime.Now;
        var today = DateTime.Today;
        
        Console.WriteLine($"Hour: {now.Hour}");
        Console.WriteLine($"Minute: {now.Minute}");

        var tomorrow = now.AddDays(1).DayOfWeek;
        Console.WriteLine(tomorrow);
        
        Console.WriteLine(now.ToLongDateString());
        Console.WriteLine(now.ToShortDateString());
        Console.WriteLine(now.ToLongTimeString());
        Console.WriteLine(now.ToShortTimeString());
        // takes an argument to stipulate the format
        Console.WriteLine(now.ToString("U"));

        
        // timespan object
        // takes hours, minutes and seconds as its arguments
        var timeSpan = new TimeSpan(1, 2, 3);
        var timeSpan2 = new TimeSpan(1, 0, 0);
        Console.WriteLine(TimeSpan.FromHours(1)); // prints 01:00:00

        var start = DateTime.Now;
        var end = DateTime.Now.AddMinutes(20);

        var duration = end - start;

        Console.WriteLine(duration);
        
        //properties
        Console.WriteLine($"Minutes: {timeSpan.Minutes}"); // prints Minutes: 2
        Console.WriteLine($"Total Minute: {timeSpan.TotalMinutes}"); // prints Total Minutes: 62.05
        

        // Add 
        // timespan methods return a new timespan object 
        Console.WriteLine($"Add: {timeSpan.Add(TimeSpan.FromMinutes(8))}");
        Console.WriteLine($"Add: {timeSpan.Subtract(TimeSpan.FromMinutes(2))}");
        
        // ToString
        Console.WriteLine($"ToString: {timeSpan.ToString()}");
        
        // parse
        Console.WriteLine($"Parse: {TimeSpan.Parse("01:02:03")}");
    }
}