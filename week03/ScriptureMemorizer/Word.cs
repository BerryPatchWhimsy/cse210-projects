public class Word
{

    private string _wordText;
    private bool _isHidden;
    

    public Word(string text)// works DONT TOUCH
    {
        _wordText = text; 
        _isHidden = false;
        //set initial visible
    }

    public void Show()
    {
        Console.WriteLine($"{_wordText} ");
        _isHidden = false;
    }

    public void Hide()//works
    {
        //hide word
        
        foreach (char w in _wordText)
        {
            Console.Write("_");
        }
        
        _isHidden = true;
        
    }

    // public string ChangeToString()
    // {
    //     return $"{_wordText} "; 
    // }

    public bool IsHidden()
    {
        //check if word is shown or hidden, true or false
        if (_isHidden == false)
        {
            return false;
        }
        else 
        {
            return true;
        }
    }

    public string GetDisplayText()//Work??
    {
        //show word or underscore
        
        if (IsHidden() == true)
        {
            Hide();
        }

        if (IsHidden() == false)
        {
            Console.Write($"{_wordText} ");
        }
        
        return _wordText;

        
    }
}
