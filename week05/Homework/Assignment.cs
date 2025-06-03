public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }

    public void getSummary()
    {
        Console.WriteLine($"{_studentName} - {_topic}");
    }

    public string getStudnentName()
    {
        return _studentName;
    }
}