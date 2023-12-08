public class OutdoorGatherings: Event
{
    private string _weather;
    public OutdoorGatherings(string title, string description, string date, string time, Address address, string weather): base(title, description, date, time, address)
    {
        _weather = weather;
    }
    public override string FullDetails()
    {
        return $"Type of event: {this.GetType()} \n{GetTitle()} \n{GetDescription()} \nDate: {GetDate()} \nTime: {GetTime()} \nAddress: {GetAddress().ToString()} \nWeather: {_weather}";
    }
    
}