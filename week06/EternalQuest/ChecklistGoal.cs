public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    //set initial amount completed to 0
    public ChecklistGoal(string goalName, string description, int points, int target, int bonus) : base(goalName, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;

    }

    //This method should do whatever is necessary for each specific kind of 
    //goal, such as marking a simple goal complete and adding to the number of 
    //times a checklist goal has been completed. It should return the point 
    //value associated with recording the event (keep in mind that it may 
    //contain a bonus in some cases if a checklist goal was just finished, 
    //for example).
    public override void RecordEvent()
    {
        int points = GetGoalPoints();

        int newAmmountCompleted = _amountCompleted + 1;
        _amountCompleted = newAmmountCompleted;

        if (IsComplete() == true)
        {
            Console.WriteLine($"Congratulations! You have earned {_bonus} points");
        }
        
        Console.WriteLine($"Congratulations! You have earned {points} points.");
    }

    //This method should return true if the goal is completed. The way you 
    //determine if a goal is complete is different for each type of goal.
    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        return false;
    }

    //return the details of a goal that could be shown in a list. It should 
    //include the checkbox, the short name, and description. Then in the case 
    //of the ChecklistGoal class, it should be overridden to show number of times
    //the goal has been accomplished so far
    public override string GetDetailsString()
    {
        string name = GetGoalName();
        string description = GetGoalDescription();
        //int points = GetGoalPoints();
        string _checkbox;

        if (IsComplete() == true)
        {
            _checkbox = "[X]";
        }
          
        _checkbox = "[ ]";
        return $"{_checkbox} {name} ({description}) -- Currently completed: {_amountCompleted}/{_target}";
        
    }


    //This method should provide all of the details of a goal in a way that is 
    //easy to save to a file, and then load later.
    public override string GetStringRepresentation()
    {
        string name = GetGoalName();
        string description = GetGoalDescription();
        int points = GetGoalPoints();
        bool complete = IsComplete();
        
        return $"ChecklistGoal: {name}, {description}, {points}, {_bonus}, {_target}";
    }
}