public class ReflectionActivity : Activity
{

    private List<string> _questions = new List<string>();
    private List<string> _prompts = new List<string>();

    public ReflectionActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        //begin with the standard starting message and prompt for the duration that is used by all activities.
        Console.Clear();
        GetOpenMessage();
        Console.Clear();

        //After the starting message, select a random prompt to show the user 
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine("");
        DisplayPrompt();
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind press <Enter>.");

        Console.ReadKey();
        Console.WriteLine("");
        Console.WriteLine("Now ponder on each of the following questions as they related to the experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.Clear();

        int seconds = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        for (int i = seconds; i > 0; i--)
        {
            //After displaying the prompt, ask the user to reflect on questions that relate to this experience. 

            //After each question pause for several seconds before continuing to the next one. 
            //While the program is paused it should display a kind of spinner.

            //continue showing random questions until it has reached the number of seconds the user specified for the duration.
            Console.WriteLine("");
            Console.WriteLine($"> {GetRandomQuestion()}");
            ShowAnimation(5);
        }

        //conclude with the standard finishing message 
        Console.WriteLine("");
        GetCloseMessage();

    }

    public string GetRandomPrompt()
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        Random randomGenerator = new Random();
        int index = randomGenerator.Next(_prompts.Count);

        string randomPrompt = _prompts[index];

        return randomPrompt;
    }
    public string GetRandomQuestion()
    {

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

        Random randomGenerator = new Random();
        int index = randomGenerator.Next(_questions.Count);

        string randomQuestion = _questions[index];

        return randomQuestion;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"---- {GetRandomPrompt()} ----");
    }

    public void DisplayQuestion()
    {
        Console.WriteLine($"{GetRandomQuestion()}");
    }

}