public class EternalGoal : Goal
{
   
    public EternalGoal(string goalName, string description, int points) : base(goalName, description, points)
    {
        
    }

    public override void RecordEvent()
    {
        int points = GetGoalPoints();
        Console.WriteLine($"Congratulations! You have earned {points} points.");
    }

    //This method should return true if the goal is completed.
    public override bool IsComplete()
    {
       //always false since eternal goals is never done
        return false;
    }

    //This method should provide all of the details of a goal in a way that is 
    //easy to save to a file, and then load later.
    public override string GetStringRepresentation()
    {
        string name = GetGoalName();
        string description = GetGoalDescription();
        int points = GetGoalPoints();
        bool complete = IsComplete();
        
        return $"EternalGoal: {name}, {description}, {points}";
    }

}