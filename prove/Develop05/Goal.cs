using System;

public class Goal
{
    protected internal string _shortName;
    protected internal string _description;
    protected internal int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public virtual void RecordEvent()
    {
        // Método pode ser sobrescrito pelas classes derivadas
        throw new NotImplementedException("This method should be overridden by derived classes.");
    }

    public virtual bool IsComplete()
    {
        // Método pode ser sobrescrito pelas classes derivadas
        throw new NotImplementedException("This method should be overridden by derived classes.");
    }

    public virtual string GetDetailsString()
    {
        return $"{_shortName}: {_description} ({_points} points)";
    }

    public virtual string GetStringRepresentation()
    {
        return $"{_shortName}: {_description}";
    }

    public virtual int CalculateScore()
    {
        return _points;
    }
}