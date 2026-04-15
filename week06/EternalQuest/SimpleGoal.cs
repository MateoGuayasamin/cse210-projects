public class SimpleGoal: Goal
{
    private bool _IsComplete;

    public SimpleGoal(string ShortName, string description, int points):base(ShortName, description, points)
    {
        _IsComplete = false;
    }
    public override void RecordEvent()
    {
        if (!_IsComplete)

        {
           _IsComplete = true;
            Console.WriteLine($"You earned {_points} points!");
        }
    }
    public override bool IsComplete()
    {
        return _IsComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_ShortName}|{_description}|{_points}|{_IsComplete}";
    }

}