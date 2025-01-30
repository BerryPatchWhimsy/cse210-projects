public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public bool IsInUSA()
    {
        if (_country == "USA")
        {
            return true;
        }

        else
        {
            return false;
        }
    }

    public string DisplayAddressString()
    {
        return $"{_streetAddress} \n{_city}, {_stateOrProvince} \n{_country}";
    }

    //Constructor
    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

}