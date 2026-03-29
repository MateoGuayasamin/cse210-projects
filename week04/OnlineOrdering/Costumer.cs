public class Customer
{
    public string _name;
    public Address _address;

    public Customer(string name, string street, string city, string state, string country)
    {
        _name = name;
        _address = new Address(street, city, state, country);
    }



    public bool IsCxFromUSA()
    {
        return _address.IsUSAcitizen();
    }

}