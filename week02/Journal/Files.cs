using System.IO;
using System;

public class Files
{

    public void writeFile(List<string> entries)
    {
        Console.WriteLine("Enter the name of the file you want to save");
        string fileName = Console.ReadLine();
        for (int i = 0; i < entries.Count; i++)
        {
            File.AppendAllText(fileName, entries[i]);
        }

    }

    public void readFile()
    {
        Console.WriteLine("What is the name of the file you want to load?");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName) == true)
        {
            File.ReadAllText(fileName);
        }

        if (File.Exists(fileName) == false)
        {
            Console.WriteLine("That file does not exist. Please try again");
        }

    }
}