using System;
using System.IO;

namespace ConsoleApp1
{
    static class Program
    {
        private const string Path = "file.txt";

        static string PrintAndGetContent(string path)
        {
            var content = File.ReadAllText(path);
            
            Console.WriteLine(content);

            return content;
        }
        
        static void Main(string[] args)
        {
            var content = PrintAndGetContent(Path);

            Console.WriteLine(content);
        }
    }
}