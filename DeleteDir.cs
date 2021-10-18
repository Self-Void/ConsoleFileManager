using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFileManager
{
    class DeleteDir
    {
        private static void Delete1(DirectoryInfo target)
        {
            try
            {
                foreach (FileInfo fi in target.GetFiles())
                {
                    Console.WriteLine(@"Deleting {0} from {1}", target.FullName, fi.Name);
                    try
                    {
                        fi.Delete();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(@"Error. Can't delete file {0}", target.FullName);
                    }
                }

                if (Directory.Exists(target.FullName.ToLower()) == true)
                {
                    Directory.Delete(target.FullName.ToLower());
                }

            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Directory Not Found Exception");
            }
        }

        public static void DeleteAll(string target)
        {
            string targetDirectory = target;

            DirectoryInfo Target = new DirectoryInfo(targetDirectory);

            Delete1(Target);
        }
    }
}
