public abstract class Activity
{
    private string _date;
    private int _duration;
    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public double GetPace()
    {
        return GetSpeed() / 60;
    }
    public string GetDate()
    {
        return _date;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public string GetSummary()
    {
        return $"{_date} {this.GetType()} ({_duration} min) Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}