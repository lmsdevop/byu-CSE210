class Cycling : Activity
{
    public double Speed { get; set; }

    public Cycling(DateTime date, int lengthMinutes, double speed) : base(date, lengthMinutes)
    {
        Speed = speed;
    }

    public override double GetDistance()
    {
        return Speed * (LengthMinutes / 60.0);
    }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetPace()
    {
        return 60 / Speed;
    }
}