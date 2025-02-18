public class Running : Activity
{
    private double _distance;

    public Running(DateTime dateTime, double minutes, double distance) : base(dateTime, minutes)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        double minutes = GetMinutes();
        double speed = (_distance/minutes) * 60;
        return speed;
    }

    public override double GetPace()
    {
        double pace = GetMinutes()/_distance;
        return pace;
    }
    
}