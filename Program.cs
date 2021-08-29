using System;
using System.IO;

namespace ConsoleFileManager
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Directory name: ");
                var dirName = Console.ReadLine();
                string[] dirs = Directory.GetDirectories(dirName);
                foreach (var dir in dirs)
                {
                    Console.WriteLine(dir);
                }

            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Directory Not Found.");
                Console.ReadLine();
            }
        }
    }
}
