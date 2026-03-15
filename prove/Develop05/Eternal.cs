public class Eternal : Goal
{
    public Eternal(int points, string name, string description) : base (points, name, description)
    {   
        _points = points;
        _name = name;
        _description = description;
    }

    public override string GetSerializedGoal()
    {
        return $"Eternal,{_name},{_description},{_points}";
    }

    public override int RecordEvent()
    {
        return _points;
    }
}