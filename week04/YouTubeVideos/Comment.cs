public class Comment
{
    public string _commentorName;
    public string _text;

    public string AsString()
    {
        return $"{_text}- {_commentorName}"; 
    }

    public void DisplayComment()
    {
        Console.WriteLine($"'{_text}' - {_commentorName}");
    }

}