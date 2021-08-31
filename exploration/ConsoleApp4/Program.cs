using System;
using System.IO;

namespace ConsoleApp4
{
    static class Program
    {
        private const string Path = "file.txt";

        static (Error?, int?) PrintAndGetContent(string path)
        {
            try
            {
                var content = File.ReadAllText(path);

                Console.WriteLine(content);

                return (null, content.Length);
            }
            catch (DirectoryNotFoundException) { return (Error.DirectoryNotFound, null); }
            catch (FileNotFoundException) { return (Error.FileNotFound, null); }
            catch (IOException) { return (Error.UnknownIOException, null); }
            catch (Exception) { return (Error.UnknownException, null); }
        }
        
        static void Main(string[] args)
        {
            var (error, contentLength) = PrintAndGetContent(Path);

            if (error is not null)
            {
                Console.Error.WriteLine($"Oops ! {error.Value}");
            }
            else
            {
                Console.WriteLine(contentLength.Value);
            }
        }
    }

    public enum Error
    {
        DirectoryNotFound,
        FileNotFound,
        UnknownIOException,
        UnknownException
    }
}