using System;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security.Principal;
using Microsoft.VisualBasic;


public class Journal
{
    public List<string> _entries = new List<string>();

    public List<string> _prompts = new List<string>
    {
        "What was the best part of your day? ",
        "Who was the most interesting person you interacted with today? ",
        "If you could change one thing about your day for the better, what would it be? ",
        "Who are you grateful for today? ",
        "Name 5 things you are grateful for. "
    };





    public string displayPrompts()
    {
        int upperBound = _prompts.Count;
        Random random = new Random();
        int rand = random.Next(0, upperBound);

        Console.WriteLine(_prompts[rand]);
        return _prompts[rand];
    }

    public void displayJournal(List<string> entries)
    {
        for (int i = 0; i < entries.Count; i++)
        {
            Console.WriteLine($"{entries[i]}");
        }
    }


    public void displayOptions()
    {
        while (true)
        {
            Console.WriteLine("1. Write a new Entry ");
            Console.WriteLine("2. Display Journal ");
            Console.WriteLine("3. Save Journal ");
            Console.WriteLine("4. Load Journal ");
            Console.WriteLine("5. Quit ");

            int selection = Convert.ToInt32(Console.ReadLine());

            if (selection == 1)
            {
                string prompts = displayPrompts();
                Entry entry = new Entry();
                string newEntry = entry.getNewEntry(prompts);
                _entries.Add(newEntry);
            }

            if (selection == 2)
            {
                displayJournal(_entries);
            }

            if (selection == 3)
            {
                Files file = new Files();
                file.writeFile(_entries);
            }

            if (selection == 4)
            {
                Files file = new Files();
                file.readFile();
            }

            if (selection == 5)
            {
                break;
            }
        }
    }
}