public class Address
{
    public string _address;
    public string _city;
    public string _state;
    public string _country;

    public Address(string address, string city, string state, string country )
    {
        _address = address;
        _city = city;
        _country= country;
        _state = state;
    }

    public bool IsUSAcitizen()
    {
        if (_country =="USA")
        {
            return true ;
        }
        else
        {
            return false;
        } 
        
    }

    public string GetDisplayAddress()
    {
        string address = $"{_address},{_city},{_state},{_country}";
        return address;
    }
}