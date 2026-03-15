public class Eternal : Goal
{

    int _completionCnt;    

    public Eternal(int points, string name, string description, int completionCount = 0) : base (points, name, description)
    {   
        _completionCnt = completionCount;
    }

    public override void DisplayGoal(int i)
    {
        Console.WriteLine($" {i}. [{_completionCnt}] {_name} ({_description})");
    }

    public override string GetSerializedGoal()
    {
        return $"Eternal,{_name},{_description},{_points},{_completionCnt}";
    }

    public override int RecordEvent()
    {
        _completionCnt += 1;
        return _points;
    }
}