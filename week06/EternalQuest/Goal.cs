abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;

    public string GetName() => _name;
    public void SetName(string name) => _name = name;

    public string GetDescription() => _description;
    public void SetDescription(string description) => _description = description;

    public int GetPoints() => _points;
    public void SetPoints(int points) => _points = points;

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStatus();
    public abstract string Serialize();
    public abstract void Deserialize(string data);
}