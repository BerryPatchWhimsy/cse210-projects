using System.Data;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _lastVerse;

    // public Reference
    // {

    // }
    public string GetReferenceSingleVerse()
    {
        string scriptRef = _book + " " + _chapter + ":" + _verse;
        return scriptRef;
    }

    public string GetReferenceVerses()
    {
        string scriptRef = _book + " " + _chapter + ":" + _verse + "-" + _lastVerse;
        return scriptRef;
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

    

    public void SetBook(string book)
    {
        _book = book;
    }

    public void SetChapter(int chapter)
    {
        _chapter = chapter;
    }

    public void SetVerse(int verse)
    {
        _verse = verse;
    }

    public void SetLastVerse(int lastVerse)
    {
        _lastVerse = lastVerse;
    }
}