public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    //initializes empty list of goals, sets initial score to 0
    public GoalManager()
    {
        _score = 0;
    }

    //This is the "main" function for this class. It is called by Program.cs, 
    //and then runs the menu loop.
    public void Start()
    {
        DisplayPlayerInfo();
        Console.WriteLine("");
        Console.WriteLine("Choose an option from the following menu: ");
        Console.WriteLine("1. Create new goal");
        Console.WriteLine("2. Display goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");

        int userInput = int.Parse(Console.ReadLine());
    
        if (userInput == 1)
        {
            CreateGoal();
        }

        if (userInput == 2)//display goals
        {
            ListGoalDetails();
        }

        if (userInput == 3)
        {
            SaveGoals();
        }

        if (userInput == 4)
        {
            LoadGoals();
        }

        if (userInput == 5)
        {
            RecordEvent();
        }

        if (userInput == 6)
        {
            Console.WriteLine("Goodbye");
        }

    }
    

    //Displays the players current score.
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou currently have {_score} points");
    }

    //lists names of each of the goals
    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count(); i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetGoalName()}");
        } 
    }

    //Lists the details of each goal (including the checkbox) 
    public void ListGoalDetails()
    {
        if (_goals.Count() == 0)
        {
            Console.WriteLine("You have no goals set.");
        }

        Console.WriteLine($"The goals are: ");
        foreach (Goal g in _goals)
        {
            Console.WriteLine(g.GetDetailsString());
        }
        
        Start();
    }

    //Asks the user for the information about a new goal. Then, creates the goal and adds it to the list.
    public void CreateGoal()
    {
        Console.WriteLine("What type of goal would you like to create?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Back to Main Menu");
        Console.Write("Select a choice from the menu: ");

        int goalType = int.Parse(Console.ReadLine());

        if (goalType == 1)
        {
            //create new simple goal
            Console.Write("\nWhat is the name of your goal? ");
            string goalName = Console.ReadLine();
            Console.Write("\nWhat is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("\nWhat is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());

            SimpleGoal sg1 = new SimpleGoal(goalName, description, points);
            _goals.Add(sg1);

        }

        if (goalType == 2)
        {
            //create new eternal goal
            Console.Write("\nWhat is the name of your goal? ");
            string goalName = Console.ReadLine();
            Console.Write("\nWhat is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("\nWhat is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());

            EternalGoal eg1 = new EternalGoal(goalName, description, points);
            _goals.Add(eg1);
        }

        if (goalType == 3)
        {
            //create new checklist goal
            Console.Write("\nWhat is the name of your goal? ");
            string goalName = Console.ReadLine();
            Console.Write("\nWhat is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("\nWhat is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());
            Console.WriteLine("\nHow many times does the goal need to be accomplished for a bonus?");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine("\nHow many bonus points awarded for accomplishing it that many times?");
            int bonus = int.Parse(Console.ReadLine());


            ChecklistGoal cg1 = new ChecklistGoal(goalName, description, points, target, bonus);
            _goals.Add(cg1);
        }

        if (goalType == 4)
        {
            Start();
        }

        Start();
    }

    //Asks the user which goal they have done, records the event by 
    //calling the RecordEvent method on that goal.
    public void RecordEvent()
    {
        Console.WriteLine("\nGoal menu:");
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");

        int userInput = int.Parse(Console.ReadLine());

        int x = userInput;
        Goal g = _goals[x - 1];
        g.RecordEvent();
        int points = g.GetGoalPoints();
        int newScore = _score + points;
        _score = newScore;

        Start();
    }

    //saves the list of goals to a file
    public void SaveGoals()
    {
        Console.WriteLine("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);
            foreach (Goal g in _goals)
            {
                outputFile.WriteLine(g.GetStringRepresentation());
            }
        }

        Start();
    }


    //loads the list of goals from a file
    public void LoadGoals()
    {
        Console.WriteLine("What is the filename for the goal file?");
        string fileName = Console.ReadLine();
        Console.WriteLine("Reading from file ...");
       
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string goal = parts[0];
            
            Console.WriteLine(goal);
        }
        
        Start();
 
    }

}