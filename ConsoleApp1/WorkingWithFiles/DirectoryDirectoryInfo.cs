namespace ConsoleApp1.WorkingWithFiles;

public class DirectoryDirectoryInfo
{
    public static void application()
    {
        
        // Directory
        var inPath = @"c:\temp\folder1";
        Directory.CreateDirectory(inPath);
        // this returns a stringArray
        // "*.*" is all files
        // "*.sln" is for solution files
        // "*.jpg" is for jpeg
        var files = Directory.GetFiles(inPath, "*.*", SearchOption.AllDirectories);
        // loops through each of the files in the returned string array and prints them
        foreach (var file in files)
        {
            Console.WriteLine(file);
        }
        
        // returns only the directories
        var directories = Directory.GetDirectories(inPath, "*.*", SearchOption.AllDirectories);

        foreach (var directory in directories)
        {
            Console.WriteLine(directory);
        }
        
        // Check if directory exists?   
        Directory.Exists(inPath);
        
        // Directory info
        // same as fileinfo
        var directoryInfo = new DirectoryInfo(inPath);
        directoryInfo.GetFiles(inPath, SearchOption.AllDirectories);
        directoryInfo.GetDirectories(inPath, SearchOption.AllDirectories);

    }
}