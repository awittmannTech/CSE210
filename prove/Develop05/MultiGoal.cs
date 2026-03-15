public class MultiGoal : Goal
{
    private int _completionBonus;
    private int _required;
    private int _timesCompleted;

    public MultiGoal(int points, string name, string description, int completionBonus, int required, int timesCompleted) : base (points, name, description)
    {   
        _completionBonus = completionBonus;
        _required = required;
        _timesCompleted = timesCompleted;
    }
}