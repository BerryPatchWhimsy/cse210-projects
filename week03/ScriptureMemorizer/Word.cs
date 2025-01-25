public class Word
{

    private string _wordText;
    private bool _isHidden;
    

    public Word(string text)
    {
        _wordText = text; 
        _isHidden = false;
        //set initial visible
    }

    public void Show()
    {
        Console.WriteLine(_wordText);
        _isHidden = false;
    }

    public void Hide()
    {
        //hide word
        
        foreach (char w in _wordText)
        {
            Console.WriteLine("_ ");
        }
        
        _isHidden = true;
        
    }

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

    public string GetDisplayText()
    {
        //show word or underscore
        
        while (IsHidden() == false)
        {
            Hide();
        }
        return _wordText;

    }
}
