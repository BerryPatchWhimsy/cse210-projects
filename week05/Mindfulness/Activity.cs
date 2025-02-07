

public class Activity
{
    //start with a common starting message that provides the name of the activity, a description, and 
    //asks for and sets the duration of the activity in seconds. 
    //Then, tell the user to prepare to begin and pause for several seconds.

    private string _name;
    private string _description;
    private int _duration;

    public void GetOpenMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine("");
        Console.WriteLine($"{_description}");
        Console.WriteLine("");
        Console.Write($"How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowAnimation(2);
    }

    //end with a common ending message that tells the user they have done a good job, and pause 
    //then tell them the activity they have completed and the length of time and 
    //pauses for several seconds before finishing.
    public void GetCloseMessage()
    {
        Console.WriteLine("\nWell done!");
        ShowAnimation(1);
        Console.WriteLine($"You have done the {_name} for {_duration} seconds.");
        ShowAnimation(3);
        Console.WriteLine("Goodbye!");
    }

    //Whenever the application pauses it should show some kind of 
    //animation to the user
    public void ShowAnimation(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(200);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }

    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 1;
    }

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetDuration()
    {
        return _duration;
    }

}