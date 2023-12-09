public class SwimingInTheLapPool: Activity
{
    private int _laps;
    public SwimingInTheLapPool(string date, int duration, int laps): base(date, duration)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return  _laps * 0.05;
    }
    public override double GetSpeed()
    {
        return (GetDistance() / GetDuration()) * 60;
    }
}