using System;
using System.IO;

namespace ConsoleApp2
{
    static class Program
    {
        private const string Path = "file.txt";

        /// <summary />
        /// <exception cref="Exception" />
        static string PrintAndGetContent(string path)
        {
            var content = File.ReadAllText(path);
            Console.WriteLine(content);

            return content;
        }
        
        static void Main(string[] args)
        {
            try
            {
                var content = PrintAndGetContent(Path);

                Console.WriteLine(content);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine($"Oops ! {e.Message}");
            }
        }
    }
}