using System;

public class Entry
{
    public string _entry = " ";
    public string _date = DateTime.Now.ToShortDateString();

    public string getNewEntry(string prompt)
    {
        _entry = prompt + $" {_date}\n";
        _entry += Console.ReadLine();
        return _entry;
    }

}