public class ListingActivity : Activity
{

    int _count;
    List<string> _prompts = new List<string>();

    public ListingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        //The activity should begin with the standard starting message 
        //and prompt for the duration that is used by all activities.
        Console.Clear();
        GetOpenMessage();

        //Then, it should prompt them to keep listing items.
        Console.WriteLine("");
        Console.WriteLine("List as many responses you can to the following prompt: ");

        //After the starting message, select a random prompt to show the user
        Console.WriteLine("");
        DisplayPrompt();

        //After displaying the prompt, the program should give them a 
        //countdown of several seconds to begin thinking about the prompt. 
        Console.WriteLine("");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        //The activity them displays back the number of items that were 
        //entered.
        List<string> userList= GetListFromUser();
        _count = userList.Count;
        Console.WriteLine("");
        Console.WriteLine($"You have listed {_count} items!");
        ShowAnimation(5);

        //The activity should conclude with the standard finishing message 
        //for all activities.
        Console.WriteLine("");
        GetCloseMessage();
    }

    private string GetRandomPrompt()
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

        Random randomGenerator = new Random();
        int index = randomGenerator.Next(_prompts.Count);

        string randomPrompt = _prompts[index];

        return randomPrompt;
    }

    private void DisplayPrompt()
    {
        Console.WriteLine($"---- {GetRandomPrompt()} ----");
    }

    public List<string> GetListFromUser()
    {
        List<string> _inputs = new List<string>();

        int seconds = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime endtime = startTime.AddSeconds(seconds);
        
        //The user lists as many items as they can until they they reach 
        //the duration specified by the user at the beginning.
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"> ");
            string userInput = Console.ReadLine();
            _inputs.Add(userInput);
        }
        
        return _inputs;

    }

  

}