class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return GetPoints();
        }
        return 0;
    }

    public override bool IsComplete() => _isComplete;

    public override string GetStatus()
        => $"[ {(IsComplete() ? "X" : " ")} ] {GetName()} ({GetDescription()})";

    public override string Serialize()
        => $"SimpleGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_isComplete}";

    public override void Deserialize(string data)
    {
        var parts = data.Split('|');
        SetName(parts[1]);
        SetDescription(parts[2]);
        SetPoints(int.Parse(parts[3]));
        _isComplete = bool.Parse(parts[4]);
    }
}