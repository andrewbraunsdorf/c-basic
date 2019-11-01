using System.IO

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\somefile.jpg";
            // @ takes it verbatium, otherwise you would have to use \\ instead of just using \s with @
            File.Copy(@"c:\TempFileCollection\myfile.jpg", @"d:\temp\myfile.jpg", true);

            File.Delete(path);
            if (File.Exists(path))
            {
                //
            }

            var content = File.ReadAllText(path);

            // file info class
            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //
            }

            fileInfo.OpenRead();
        }
    }
}
