public class Entry
{
    public DateTime _date = DateTime.Now;
    public string _response;// = Console.ReadLine();
    public string _randomPrompt;

    public string SaveToString()
    {
        return $"{_date},{_randomPrompt},{_response}"; 
    }
    
    public void DisplayEntry()//works DON'T TOUCH
    {
        Console.WriteLine($"Date: {_date} - {_randomPrompt}");
        Console.WriteLine($"{_response}");

    }
}