abstract class Activity
{
    public DateTime Date { get; set; }
    public int LengthMinutes { get; set; }

    public Activity(DateTime date, int lengthMinutes)
    {
        Date = date;
        LengthMinutes = lengthMinutes;
    }

    // Abstract methods to be overridden by derived classes
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Method to get summary information
    public string GetSummary()
    {
        return $"{Date.ToShortDateString()} {GetType().Name} ({LengthMinutes} min) - Distance: {GetDistance()}, Speed: {GetSpeed()}, Pace: {GetPace()}";
    }
}