public class Receptions: Event
{
    private string _email;
    public Receptions(string title, string description, string date, string time, Address address, string email): base(title, description, date, time, address)
    {
        _email = email;
    }
    public override string FullDetails()
    {
        return $"Type of event: {this.GetType()} \n{GetTitle()} \n{GetDescription()} \nDate: {GetDate()} \nTime: {GetTime()} \nAddress: {GetAddress().ToString()} \nEmail Address for RSVP: {_email}";
    }
}