public abstract class Activity
{
    private DateTime _dateTime;
    private double _minutes;

    public Activity(DateTime dateTime, double minutes)
    {
        _dateTime = dateTime;
        _minutes = minutes;
    }
    public abstract double GetSpeed();
    public abstract double GetDistance();
    public abstract double GetPace();

    public double GetMinutes()
    {
        return _minutes;
    }

    public DateTime GetDate()
    {
        return _dateTime;
    }

    // public string GetSummary()
    // {
    //     int distance = GetDistance();
        
    //     int speed = GetSpeed();
    //     int pace = GetPace();
    //     return $"{_dateTime} Running ({_minutes})- Distance {distance} kilometers, Speed {speed} km/h, Pace: {pace} min per mile.";
    // }
    
    

}