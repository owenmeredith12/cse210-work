class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _targetCount;
    private int _bonusPoints;

    public void SetTargetCount(int count) => _targetCount = count;
    public void SetBonusPoints(int bonus) => _bonusPoints = bonus;

    public override int RecordEvent()
    {
        if (_timesCompleted < _targetCount)
        {
            _timesCompleted++;
            if (_timesCompleted == _targetCount)
            {
                return GetPoints() + _bonusPoints;
            }
            return GetPoints();
        }
        return 0;
    }

    public override bool IsComplete() => _timesCompleted >= _targetCount;

    public override string GetStatus()
        => $"[ {(IsComplete() ? "X" : " ")} ] {GetName()} ({GetDescription()}) -- Completed {_timesCompleted}/{_targetCount}";

    public override string Serialize()
        => $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_bonusPoints}|{_targetCount}|{_timesCompleted}";

    public override void Deserialize(string data)
    {
        var parts = data.Split('|');
        SetName(parts[1]);
        SetDescription(parts[2]);
        SetPoints(int.Parse(parts[3]));
        _bonusPoints = int.Parse(parts[4]);
        _targetCount = int.Parse(parts[5]);
        _timesCompleted = int.Parse(parts[6]);
    }
}