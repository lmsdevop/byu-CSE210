class Address
{
    public string _street { get; }
    public string _city { get; }
    public string _stateProvince { get; }
    public string _country { get; }

    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public bool IsInUSA()
    {
        return _country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    public override string ToString()
    {
        return $"{_street}, {_city}, {_stateProvince}, {_country}";
    }
}