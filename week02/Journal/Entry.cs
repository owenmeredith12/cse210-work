using System;

public class Entry
{
    public string _entry = " ";
    public string _date = DateTime.Now.ToShortDateString();

    public int _length = 0;

    public string getNewEntry(string prompt)
    {
        _entry = prompt + $" {_date}\n";
        string entry = Console.ReadLine();

        string[] length = entry.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        _length = length.Length;
        _entry += entry;
        _entry += $"\n{_length} words";
        return _entry;
    }

}