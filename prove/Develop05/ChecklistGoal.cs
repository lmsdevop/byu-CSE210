public class ChecklistGoal : Goal
{
    protected internal int _amountCompleted;
    protected internal int _target;
    protected internal int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted = 0)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
    }

    public override bool IsComplete()
    {
        return _amountCompleted == _target;
    }

    public override string GetStringRepresentation()
    {
        if (_amountCompleted == _target)
        {
            return $"[X] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
        else { return $"[ ] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}"; }
    }

    public override int CalculateScore()
    {
        if (IsComplete())
            return (_points * _target) + _bonus;
        else
            return _points;
    }
}