public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime dateTime, double minutes, double speed) : base(dateTime, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        double distance = (_speed/60) * GetMinutes();
        return distance;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        double pace = 60/GetSpeed();
        return pace;
    }
    // public override string GetSummary()
    // {
    //     return $"{_distance}";
    // }
}