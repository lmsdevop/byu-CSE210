class Running : Activity
{
    public double Distance { get; set; }

    public Running(DateTime date, int lengthMinutes, double distance) : base(date, lengthMinutes)
    {
        Distance = distance;
    }

    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetSpeed()
    {
        return Distance / (LengthMinutes / 60.0);
    }

    public override double GetPace()
    {
        return LengthMinutes / Distance;
    }
}