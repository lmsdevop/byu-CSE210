class Reception : Event
{
    public string _RSVP { get; set; }

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvp)
        : base(title, description, date, time, address)
    {
        _RSVP = rsvp;
    }

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nRSVP: {_RSVP}";
    }
}