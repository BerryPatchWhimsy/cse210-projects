public class Assignment
{
    //protected string _studentName;
    private string _studentName;
    private string _topic;

    public Assignment()
    {
        _studentName = "";
        _topic = "";
    }

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}"; 
    }

    //alternative to "protected" status for student name
    public string GetStudentName()
    {
        return _studentName;
    }

    
}