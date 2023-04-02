namespace ConsoleApp1.WorkingWithFiles;

public class SectionExercises
{
    private static string directoryPath = "/Users/martynclarke/Desktop/file_exercises";
    private static string filePath = Path.Combine(directoryPath, "lookatme.txt");

    private static void CreateFile(string path)
    {
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
    }

    private static void writeContent(string path)
    {
        Console.WriteLine($"What would you like to write to the file?");
        var input = Console.ReadLine();
        Console.WriteLine($"Would you like it to append or overwrite");
        var should = Console.ReadLine(); 
        var shouldAppend = should.ToLower() == "yes";
        using StreamWriter writer = new StreamWriter(path, shouldAppend);
        writer.WriteLine(input);
    }

    private static string ReadContent(string path)
    {
        if (!File.Exists(path))
        {
            throw new FileNotFoundException("File Not Found", path);
        }

        return File.ReadAllText(path);
    }

    private static string ReturnLargest(string content)
    {
        var currentLongest = "";
        foreach (var word in content.Split())
        {
            if (word.Length > currentLongest.Length)
                currentLongest = word;
        }

        return currentLongest;
    }
    
    public static void Application()
    {
        CreateFile(directoryPath);
        writeContent(filePath);
        
        Console.Write($"Would you like to read the file you just wrote?...Yes/No: ");
        var shouldRead = Console.ReadLine().ToLower();
        if(shouldRead == "yes") 
            Console.WriteLine(SectionExercises.ReadContent(filePath));

        Console.Write($"Would you like to know how many words are in the file?...Yes/No: ");
        var shouldCount = Console.ReadLine().ToLower();
        
        if (shouldCount != "yes") return;
        var content = SectionExercises.ReadContent(filePath);
        var wordArray = content.Split(" ").Length;
        Console.WriteLine($"There are {content.Split(' ').Length} words in the file...");

        Console.WriteLine($"Do you want to know what the longest word is inside your file?...Yes/No: ");
        var shouldFindLargest = Console.ReadLine().ToLower();
        if(shouldFindLargest == "yes")
            Console.WriteLine($"The longest word is {SectionExercises.ReturnLargest(content)}");

    }
}

public class FilesAndDirectories
{
    public static void app()
    {
        Console.WriteLine($"-------------Exercise 1------------");
        // FileAndFileInfo.application();
        
        Console.WriteLine($"-------------Exercise 2------------");
        // DirectoryDirectoryInfo.application();
        
        Console.WriteLine($"-------------Exercise 3------------");
        SectionExercises.Application();
    }
}