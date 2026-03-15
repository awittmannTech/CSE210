public class MultiGoal : Goal
{
    private int _completionBonus;
    private int _completionCntGoal;
    private int _timesCompleted;

    public MultiGoal(int points, string name, string description, int completionBonus, int completionCntGoal, int timesCompleted = 0) : base (points, name, description)
    {   
        _completionBonus = completionBonus;
        _completionCntGoal = completionCntGoal;
        _timesCompleted = timesCompleted;
    }

    public override void DisplayGoal(int i)
    {
        Console.WriteLine($" {i}. [{(_timesCompleted >= _completionCntGoal ? "X" : " ")}] {_name} ({_description}) -- Currently completed: {_timesCompleted}/{_completionCntGoal}");
    }

    public override string GetSerializedGoal()
    {
        return $"MultiGoal,{_name},{_description},{_points},{_completionBonus},{_completionCntGoal},{_timesCompleted}";
    }

    public override int RecordEvent()
    {
        _timesCompleted += 1;

        int pointsAwarded = _points;

        if(_timesCompleted == _completionCntGoal)
        {
            pointsAwarded += _completionBonus;
        }

        return pointsAwarded;
    }
}