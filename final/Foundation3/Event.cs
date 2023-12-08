public abstract class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address  _address;
    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public string StandardDetails()
    {
        return $"{_title} \n{_description} \nDate: {_date} \nTime: {_time} \nAddress: {_address.ToString()}";
    }
    public abstract string FullDetails();
    public string GetTitle()
    {
        return _title;
    }
    public string GetDescription()
    {
        return _description;
    }
    public string GetDate()
    {
        return _date;
    }
    public string GetTime()
    {
        return _time;
    }
    public Address GetAddress()
    {
        return _address;
    }
    public string ShortDescription()
    {
        return $"Type of event: {this.GetType()} \n{_title} \nDate: {_date}";
    }
}
    