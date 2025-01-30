using System.Data;

// Reference class works -- DONT TOUCH

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _lastVerse;


    public Reference()//necessary?
    {
        _book = "";
        _chapter = 0;
        _verse = 0;
    }

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int verse, int lastVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _lastVerse = lastVerse;
    }

    

    

    // public void SetBook(string book)
    // {
    //     _book = book;
    // }

    // public void SetChapter(int chapter)
    // {
    //     _chapter = chapter;
    // }

    // public void SetVerse(int verse)
    // {
    //     _verse = verse;
    // }

    // public void SetLastVerse(int lastVerse)
    // {
    //     _lastVerse = lastVerse;
    // }

    public string GetReference()
    {
        string scriptRef;

        if (_lastVerse == 0)
        {
            scriptRef = $"{_book} {_chapter}:{_verse}";
        }

        else 
        {
            scriptRef = $"{_book} {_chapter}:{_verse}-{_lastVerse}";
        }
        //string scriptRef = _book + " " + _chapter + ":" + _verse + "-" + _lastVerse;
        
        return scriptRef;
    }
}