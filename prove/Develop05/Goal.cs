public abstract class Goal
{
    protected int _points;
    protected string _name;
    protected string _description;

    public Goal(int points, string name, string description)
    {   
        _points = points;
        _name = name;
        _description = description;
    }

    public string GetDisplayName()
    {
        return _name;
    }

    public string GetDisplayDescription()
    {
        return _description;
    }

    public int GetPointValue()
    {
        return _points;
    }
    
    public virtual void DisplayGoal(int i)
    {
        Console.WriteLine($" {i}. [ ] {_name} ({_description})");
    }

    public abstract string GetSerializedGoal();
    public abstract int RecordEvent();

}