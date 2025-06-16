class EternalGoal : Goal
{
    public override int RecordEvent() => GetPoints();
    public override bool IsComplete() => false;

    public override string GetStatus()
        => $"[∞] {GetName()} ({GetDescription()})";

    public override string Serialize()
        => $"EternalGoal|{GetName()}|{GetDescription()}|{GetPoints()}";

    public override void Deserialize(string data)
    {
        var parts = data.Split('|');
        SetName(parts[1]);
        SetDescription(parts[2]);
        SetPoints(int.Parse(parts[3]));
    }
}