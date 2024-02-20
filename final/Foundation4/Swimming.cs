class Swimming : Activity
{
    public int Laps { get; set; }
    private const double LapLengthMeters = 50.0;

    public Swimming(DateTime date, int lengthMinutes, int laps) : base(date, lengthMinutes)
    {
        Laps = laps;
    }

    public override double GetDistance()
    {
        return Laps * LapLengthMeters / 1000; // Convert meters to kilometers
    }

    public override double GetSpeed()
    {
        return GetDistance() / (LengthMinutes / 60.0);
    }

    public override double GetPace()
    {
        return LengthMinutes / GetDistance();
    }
}