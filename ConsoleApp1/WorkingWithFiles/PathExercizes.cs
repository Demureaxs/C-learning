namespace ConsoleApp1.WorkingWithFiles;

public class PathExercizes
{
    public static void Applications()
    {
        var path = @"c:\Projects\CSharpFundamentals\HelloWorld\HelloWorld.sln";

        var dotIndex = path.IndexOf('.');
        var extension = path.Substring(dotIndex);

        Console.WriteLine($"Extension: {Path.GetExtension(path)}");
        Console.WriteLine($"File Name: {Path.GetFileName(path)}");
        Console.WriteLine($"File Name Without Extension: {Path.GetFileNameWithoutExtension(path)}");
        Console.WriteLine($"Directory Name: {Path.GetDirectoryName(path)}");
        
    }
}