public class SimpleGoal : Goal
{
    private bool _isComplete;

    //initially set to be false
    public SimpleGoal(string goalName, string description, int points) : base(goalName, description, points)
    {
        _isComplete = false;
    }

    //marking a simple goal complete,return the point 
    //value associated with recording the event 
    public override void RecordEvent()
    {
        _isComplete = true;
        int points = GetGoalPoints();
        Console.WriteLine($"Congratulations! You have earned {points} points.");
        
    }

    //This method should return true if the goal is completed.
    public override bool IsComplete()
    {
        if (_isComplete == false)
        {
            return false;
        }
        
        return true;
    }

    //Tall of the details of a goal in a way that is easy to save to a file, and load later.
    public override string GetStringRepresentation()
    {
        string name = GetGoalName();
        string description = GetGoalDescription();
        int points = GetGoalPoints();
        bool complete = IsComplete();
        
        return $"SimpleGoal: {name}, {description}, {points}, {complete}";
    }

}