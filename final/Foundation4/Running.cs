public class Running : Activity
{
    private float _distance;

    public Running(string date, int minutes, float distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override float GetDistance()
    {
        return _distance;
    }

    public override float GetSpeed()
    {
        return (_distance / _minutes) * 60;
    }

    public override float GetPace()
    {
        return _minutes / _distance;
    }
}
