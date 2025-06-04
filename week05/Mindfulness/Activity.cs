using System.Diagnostics;
using System.Diagnostics.Contracts;

public abstract class Activity
{
    private string _activityName;
    private string _description;

    private int _length;

    public Activity(string name, string description)
    {
        _activityName = name;
        _description = description;
    }

    public void start()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} activity.");
        Console.WriteLine(_description);
        Console.WriteLine("Enter duration in seconds");
        _length = int.Parse(Console.ReadLine());
        showAnim(4);
    }

    public void showAnim(int seconds)
    {
        string[] spinner = { "/", "-", "\\", "|" };
        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(750);
            Console.Write("\b");
        }

    }

    public void countdown(int seconds)
    {
        Stopwatch s = new Stopwatch();
        s.Start();
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
            Console.Write("\b\b\b");
        }
    }

    public int GetLength() => _length;

    public void stop()
    {
        Console.WriteLine("Good Job");
        Console.WriteLine($"You have finished {_activityName} in {_length} seconds");
    }
    public abstract void runActivity();
}