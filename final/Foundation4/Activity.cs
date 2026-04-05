public abstract class Activity
{
    protected string _date;
    protected int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }
    
    public abstract float GetDistance();
    public abstract float GetSpeed();
    public abstract float GetPace();
    public string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_minutes} min) - Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}