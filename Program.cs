using System;
using System.IO;

namespace ConsoleFileManager
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            if (input == "ls")
            
                while (true)
                {
                    Console.WriteLine("Choose directory to find");
                    input = Console.ReadLine();
                    if (input == "stop")
                    {
                        break;
                    }
                    FindDir.FindAll(input);
                }
            

            if (input == "copy") 
            
                while (true)
                {
                    while (input.ToLower() != "next")
                    {
                        Console.Write("Choose directory: ");
                        input = Console.ReadLine();
                        FindDir.FindAll(input);
                        Console.WriteLine("If you want to continue, text NEXT");
                    }
                    if (input == "stop")
                    {
                        break;
                    }
                    Console.WriteLine("Choose source to copy");
                    var source = Console.ReadLine();
                    Console.WriteLine("Choose target to copy");
                    var target = Console.ReadLine();
                    FindDir.FindAll(input);
                    CopyDir.CopyAll(source, target);
                }

            if (input == "delete")
            {
                while (true)
                {
                    while (input.ToLower() != "next")
                    {
                        Console.Write("Choose directory: ");
                        input = Console.ReadLine();
                        FindDir.FindAll(input);
                        Console.WriteLine("If you want to continue, text NEXT");
                    }
                    Console.WriteLine("Choose target to delete");
                    input = Console.ReadLine();
                    if (input == "stop")
                    {
                        break;
                    }
                    DeleteDir.DeleteAll(input);
                }
            }

            if (input == "attribute")
            {
                while (true)
                {
                    while (input.ToLower() != "next")
                    {
                        Console.Write("Choose directory: ");
                        input = Console.ReadLine();
                        FindDir.FindAll(input);
                        Console.WriteLine("If you want to continue, text NEXT");
                    }
                    Console.WriteLine("Choose directory or file to check info");
                    input = Console.ReadLine();
                    if (input == "stop")
                    {
                        break;
                    }
                    FileAttribute.GetAttributes(input);
                }
            }
        }
    }
}
