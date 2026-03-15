public class OneTime : Goal
{
    private bool _completed;

    public OneTime(int points, string name, string description, bool completed) : base (points, name, description)
    {   
        _completed = completed;
    }

    public override void DisplayGoal(int i)
    {
        Console.WriteLine($" {i}. [{(_completed ? "X" : " ")}] {_name} ({_description})");
    }

    public override string GetSerializedGoal()
    {
        return $"OneTime,{_name},{_description},{_points},{(_completed ? 1 : 0)}";
    }

    public override int RecordEvent()
    {
        if(_completed)
        {
            return 0;
        }
        
        _completed = true;
        return _points;
    }
}