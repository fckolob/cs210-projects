public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
        
    }
    public string GetStreetAddress()
    {
        return _streetAddress;
    }
    public string GetCity()
    {
        return _city;
    }
    public string GetState()
    {
        return _state;
    }
    public string GetCountry()
    {
        return _country;
    }
    public override string ToString()
    {
        return $"{_streetAddress} \n {_city} \n {_state} \n {_country}";
    }
    public bool GetUsaCountry()
    {
        if (_country.ToLower() == "usa")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}