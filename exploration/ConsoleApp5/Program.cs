using System;
using System.IO;
using LanguageExt;

namespace ConsoleApp4
{
    static class Program
    {
        private const string Path = "file.txt";

        static Either<IOException, string> PrintAndGetContent(string path)
        {
            try
            {
                var content = File.ReadAllText(path);
            
                Console.WriteLine(content);

                return content;
            }
            catch (IOException e)
            {
                return e;
            }
        }
        
        static void Main(string[] args)
        {
            var eitherContent = PrintAndGetContent(Path);

            eitherContent.Match(
                content => Console.WriteLine(content.Length),
                error => Console.Error.WriteLine($"Oops ! {error.Message}")
            );
        }
    }
}