abstract class Activity
{
    public DateTime _date { get; set; }
    public int _lengthMinutes { get; set; }

    public Activity(DateTime date, int lengthMinutes)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
    }

    // Abstract methods to be overridden by derived classes
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Method to get summary information
    public string GetSummary()
    {
        return $"{_date.ToShortDateString()} {GetType().Name} ({_lengthMinutes} min) - Distance: {GetDistance()}, Speed: {GetSpeed()}, Pace: {GetPace()}";
    }
}