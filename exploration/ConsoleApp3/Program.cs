using System;
using System.IO;

namespace ConsoleApp3
{
    static class Program
    {
        private const string Path = "file.txt";

        static (IOException?, string?) PrintAndGetContent(string path)
        {
            try
            {
                var content = File.ReadAllText(path);
            
                Console.WriteLine(content);

                return (null, content);
            }
            catch (IOException e)
            {
                return (e, null);
            }
            
        }
        
        static void Main(string[] args)
        {
            var (error, content) = PrintAndGetContent(Path);

            if (error is not null)
            {
                Console.Error.WriteLine($"Oops ! {error.Message}");
            }
            else
            {
                Console.WriteLine(content.Length);
            }
        }
    }
}
