using System;
using System.IO;

public class FindDir
{
	public static void FindAll(string target)
    {
        try
        {
            if (Directory.Exists(target.ToLower()) == true)
            {
                string[] Dir = Directory.GetDirectories(Convert.ToString(target));
                foreach (var subDirs in Dir)
                {
                    Console.WriteLine(subDirs);
                }
            }
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("DirectoryNotFoundException");
        }
    }
}
