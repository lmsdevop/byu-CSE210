class Swimming : Activity
{
    public int _laps { get; set; }
    private const double LapLengthMeters = 50.0;

    public Swimming(DateTime date, int lengthMinutes, int laps) : base(date, lengthMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * LapLengthMeters / 1000; // Convert meters to kilometers
    }

    public override double GetSpeed()
    {
        return GetDistance() / (_lengthMinutes / 60.0);
    }

    public override double GetPace()
    {
        return _lengthMinutes / GetDistance();
    }
}