public class OneTime : Goal
{
    private bool _complete;

    public OneTime(int points, string name, string description, bool complete) : base (points, name, description)
    {   
        _complete = complete;
    }
}