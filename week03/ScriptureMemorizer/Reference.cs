using System.Data;

// Reference class works -- DONT TOUCH

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _lastVerse;


    //get dipslay text of the reference as a string that combines book, chapter, verse or verses
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

    //constructor for  parameters: book, chapter, single verse
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    //constructor for parameters: book, chapter, multiple verses
    public Reference(string book, int chapter, int verse, int lastVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _lastVerse = lastVerse;
    }
}