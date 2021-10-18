using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFileManager
{
    class FileAttribute
    {
        public static void GetAttributes(string path)
        {
            FileAttributes attributes = File.GetAttributes(path);
            if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
            { Console.WriteLine("Read only"); }
            else { Console.WriteLine("Not Read only"); }
            if ((attributes & FileAttributes.Hidden) == FileAttributes.ReadOnly)
            { Console.WriteLine("Hidden"); }
            else { Console.WriteLine("Not Hidden"); }
            if ((attributes & FileAttributes.System) == FileAttributes.ReadOnly)
            { Console.WriteLine("System File"); }
            else { Console.WriteLine("Not system File"); }
            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] fiArr = di.GetFiles();
            Console.WriteLine("The directory {0} contains the following files:", di.Name);
            foreach (FileInfo f in fiArr)
                Console.WriteLine("The size of {0} is {1} bytes.", f.Name, f.Length);
        }
    }
}
