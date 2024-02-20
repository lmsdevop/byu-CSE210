class Event
{
    public string _title { get; set; }
    public string _description { get; set; }
    public DateTime _date { get; set; }
    public TimeSpan _time { get; set; }
    public Address _address { get; set; }

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"Event Title: {_title}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_time.ToString(@"hh\:mm")}\nAddress: {_address}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"{GetType().Name}: {_title}, Date: {_date.ToShortDateString()}";
    }
}