using System;

class Program
{
    static void Main(string[] args)
    {
        
        DateTime date= DateTime.Now;
        Running r1 = new Running(date, 15, 5);
        Cycling c1 = new Cycling(date, 75, 23);
        Swimming s1 = new Swimming(date, 30, 10);

        List<Activity> _activities = new List<Activity>();

        _activities.Add(r1);
        _activities.Add(c1);
        _activities.Add(s1);

        Console.Clear();

        foreach (Activity activity in _activities)
        {
            GetSummary(activity);
        }

    }

    public static void GetSummary(Activity activity)
    {
        double distance = activity.GetDistance();
        DateTime date = activity.GetDate();
        double speed = activity.GetSpeed();
        double minutes = activity.GetMinutes();
        double pace = activity.GetPace();
        Console.WriteLine($"{date} {activity} ({minutes} minutes)- Distance {distance} kilometers, Speed {speed} km/h, Pace: {pace} min per kilometer.");
    }
}