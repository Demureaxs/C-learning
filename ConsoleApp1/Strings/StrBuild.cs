using System.Text;

namespace ConsoleApp1;

public class StrBuild
{
    public static void buildDem()
    {
        var builder = new StringBuilder("Hello World");
        // appends 10 -'s
        builder
            .Append('-', 10)
            .AppendLine()
            .Append("Header")
            .AppendLine()
            .Append('-', 10)
            .Replace('-', '+')
            .Remove(0, 10)
            .Insert(0, new string('-', 10));

        Console.WriteLine(builder);
        // first character printed only
        Console.WriteLine(builder[0]);
    }
}