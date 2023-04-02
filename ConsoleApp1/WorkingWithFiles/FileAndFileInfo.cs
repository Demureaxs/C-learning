namespace ConsoleApp1.WorkingWithFiles;

public class FileAndFileInfo
{
    public static void application()
    {
        // validation required for each operation
        
        // file static methods
        var path = @"c:\somefile.jpg";
        // copys a file from ctem to dtemp, overwrite true is the 3rd argument
        File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
        // deletes a file if it is found
        File.Delete(path);

        if (File.Exists(path))
        {
            // perform an action
        }

        // validation only happens once
        var content = File.ReadAllText(path);
        
        // fileinfo inline methods
        // creates a new fileinfo object
        var fileInfo = new FileInfo(path);
        // copy to allows us to copy the file, first argument is path, second is overwrite
        fileInfo.CopyTo(@"...", true);
        fileInfo.Delete();

        if (fileInfo.Exists)
        {
            // do something
        }

        fileInfo.OpenRead();
    }
}