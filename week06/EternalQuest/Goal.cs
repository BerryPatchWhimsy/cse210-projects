public abstract class Goal
{
    private string _goalName;
    
    private string _description;

    private int _points;

   
    public Goal(string goalName, string description, int points)
    {
        _goalName = goalName;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    
    //return the details of a goal that could be shown in a list. 
    //include the checkbox, the short name, and description. 
    public virtual string GetDetailsString()
    {
        string _checkbox;

        if (IsComplete() == true)
        {
            _checkbox = "[X]";
            return $"{_checkbox} {_goalName} ({_description})";
        }
          
        _checkbox = "[ ]";
        return $"{_checkbox} {_goalName} ({_description})";
    }


    //This method should provide all of the details of a goal in a way that is 
    //easy to save to a file, and then load later.
    public abstract string GetStringRepresentation();

    public string GetGoalName()
    {
        return _goalName;
    }

    public string GetGoalDescription()
    {
        return _description;
    }

    public int GetGoalPoints()
    {
        return _points;
    }

}