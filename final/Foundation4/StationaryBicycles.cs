public class StationaryBicycles: Activity
{
    private double _speed;
    public StationaryBicycles(string date, int duration, double speed): base(date, duration)
    {
        _speed = speed;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetDistance()
    {
        return (_speed * GetDuration()) / 60;
    }
}