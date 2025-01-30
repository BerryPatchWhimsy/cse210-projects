public class Video
{
    public string _title;
    public string _author;
    public double _length;
    public List<Comment> _comments = new List<Comment>();

    public int NumberOfComments()
    {
        //list count
        int numberComments = _comments.Count();
        return numberComments;
    }

    // public string AsString()
    // {
    //     Console.WriteLine("");
    //     Console.WriteLine($"'{_title}', by- {_author} ({_length}seconds): ");
    //     Console.Write(NumberOfComments());
    //     Console.WriteLine(" comments:");
    //     foreach (Comment comment in _comments)
    //     {
    //         Console.WriteLine(comment.AsString());
    //     }
    //     Console.WriteLine("");
    // }

    public void DisplayVideo()
    {

        Console.WriteLine("");
        Console.WriteLine($"'{_title}', by- {_author} ({_length}seconds): ");
        Console.Write(NumberOfComments());
        Console.WriteLine(" comments:");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.AsString());
        }
        Console.WriteLine("");
    }
}