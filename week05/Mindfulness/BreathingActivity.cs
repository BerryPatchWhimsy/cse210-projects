using System.Diagnostics;

public class BreathingActivity : Activity
{
   
    public BreathingActivity(string name, string description) : base(name, description)
    {
       
    }

    public void Run()
    {
        //begin with the standard starting message and prompt for the duration that is used by all activities.
        Console.Clear();
        GetOpenMessage();
        

        //continue until it has reached the number of seconds the user specified for the duration.
        int seconds = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        for (int i = seconds; i > 0; i--)
        {
            //After the starting message, the user is shown a series of messages  "Breathe in..." and "Breathe out..."
            //After each message, pause for several seconds and show a countdown.
            Console.Write("\nBreath in...");
            ShowCountDown(5);
            Console.WriteLine(" ");
            Console.Write("Breathe out...");
            ShowCountDown(5);
            Console.WriteLine(" ");
        }

        //conclude with the standard finishing message 
        GetCloseMessage();
    }

}