using System.ComponentModel;

public class Goal
{
    protected  string _ShortName;
    protected  string _description;
    protected  int _points;

    public Goal(string ShortName, string description, int points)
    {
        _ShortName = ShortName;
        _description = description;
        _points = points;
    }
    public virtual void RecordEvent()
    {
        
    }
    public virtual  bool IsComplete()
    {
        return false;
    }
    public virtual string GetDetailsString()
    {
        return $"[ ] {_ShortName} ({_description})";
    }
    public virtual string GetStringRepresentation()
    {
        return $"{_ShortName}|{_description}|{_points}";
    }
}