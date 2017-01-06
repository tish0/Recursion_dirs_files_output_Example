using System;
using System.IO;



public  class Recursion
{
       static void Main(string[] args)
       {
        TraverseDirectory("d:/ss");
       }

    public static void TraverseDirectory(string directory)
    {
        
        Console.WriteLine($"--{directory}--");
        

        string[] allFilles = Directory.GetFiles(directory);

        foreach (var file in allFilles)
        {
            Console.WriteLine(file);
        }

        string[] allDirs = Directory.GetDirectories(directory);

        foreach (var dir in allDirs)
        {
            TraverseDirectory(dir);
        }
    }
}

