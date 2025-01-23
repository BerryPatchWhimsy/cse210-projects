public class Word
{

    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text; 
        _isHidden = false;
        //set initial visible
    }

    public void Show()
    {
        _isHidden = false;
        Console.WriteLine(_text);
    }

    public void Hide()
    {
        // int x = _text.Count();
        // foreach (int i in x; i++)
        // {
        //     Console.Write("_ ");

        // }
        foreach (char w in _text)
        {
            Console.WriteLine("_ ");
        }
        
        _isHidden = true;
        //Console.WriteLine(_text);
        //hide word
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
        bool txt = IsHidden();

        if (txt == false)
        {
            return _text;
        }
        else
        {
            return "___";
            // foreach (char w in _text)
            // {
            //     Console.WriteLine("_ ");
            // }
        }
    }
}





    // private string _text;

    // private bool isHidden;

    // public void ShowWord()
    // {
    //     Console.Write(_text);
    //     isHidden = false;
    // }

    // public void HideWord()
    // {
    //     foreach (char w in _text)
    //     {
    //         Console.WriteLine("_ ");
    //         isHidden = true;
    //     }
    // }

    // public bool IsHidden()
    // {
    //     Words w1 = new Words();

    //     //string hiddenWord = w1.HideWord();
    //     if (_text == "")
        
    //         return false;
    //     }

    // }

    // public string GetDisplayText()
    // {
    //     if (IsHidden == false)
    //     {
    //         return _word;
    //     }

    //     else
    //     {
    //         return HideWord();
    //     }
    
    // }




// using System;

// 