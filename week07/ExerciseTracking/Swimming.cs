public class Swimming : Activity
{
    private double _numberOfLaps;

    public Swimming(DateTime dateTime, double minutes, double numberOfLaps) : base(dateTime, minutes)
    {
        _numberOfLaps = numberOfLaps;
    } 

    public override double GetDistance()
    {
        double distance = _numberOfLaps * 50 / 1000;
        return distance;
    }

    public override double GetSpeed()
    {
        double speed = GetDistance()/GetMinutes() * 60;
        return speed;
    }

    public override double GetPace()
    {
        double pace = GetMinutes()/GetSpeed();
        return pace;
    }
}
