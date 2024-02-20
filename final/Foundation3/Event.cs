class Event
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan Time { get; set; }
    public Address Address { get; set; }

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        Address = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"Event Title: {Title}\nDescription: {Description}\nDate: {Date.ToShortDateString()}\nTime: {Time.ToString(@"hh\:mm")}\nAddress: {Address}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"{GetType().Name}: {Title}, Date: {Date.ToShortDateString()}";
    }
}