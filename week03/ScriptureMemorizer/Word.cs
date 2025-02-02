public class Word
{
    private string _wordText;
    private bool _isHidden;
    
    //show a word
    public void Show()
    {
        Console.WriteLine($"{_wordText} ");
        _isHidden = false;
    }

    //hide a word
    public void Hide()//works
    {
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

    //check if a word is hidden or not
    public bool IsHidden()
    {
        if (_isHidden == false)
        {
            return false;
        }
        else 
        {
            return true;
        }
    }

    //get the display text of a word either the text of the word or underscores
    public string GetDisplayText()//Work??
    {
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

    //constructor with string text parameter, set initially as visible
    public Word(string text)// works DONT TOUCH
    {
        _wordText = text; 
        _isHidden = false;
    }
}
