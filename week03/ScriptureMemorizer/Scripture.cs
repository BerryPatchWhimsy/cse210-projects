using System;
public class Scripture
{
    public List<Word> _words = new List<Word>();
    public Reference _reference;

    public void HideRandomWords(int numberToHide)
    {
        // Random randomGenerator = new Random();
    //  // string index = randomGenerator.Next(_words.Count);
    //  // string _randomWord = _words[index];
    }

    

    public string GetDisplayText()
    {
        r1.(GetDisplayText);
        HideRandomWords(3);
        return "";
    }

    public bool IsCompletelyHidden()
    {
       
        
            Word w1 = new Word("");
            if(w1.IsHidden() == true)
            {
                return true;
            }

            if(w1.IsHidden() == false)
            {
                return false;
            }
        
    }

    public Scripture(Reference reference, string _text)
    {
        //break _text string into Word objects and add to list?

        foreach (string text in _text)
        {
            Word w1 = new Word(text);
            _words.Add(w1);
        }
        //_words.Add(_text);
        //Console.WriteLine($"{reference}- {_words}");
    }


    // public void DisplayReferenceSingleVerse()
    // {
    //     Reference r1 = new Reference(book, chapter, verse);
    //     r1.GetReferenceSingleVerse();
    // }

    // public void DisplayReferenceVerses()
    // {
    //     Reference r1 = new Reference(book, chapter, firstVerse, lastVerse);
    //     r1.GetReferenceVerses();
    // }

    // public void DisplayScripture()
    // {
    //     Console.WriteLine(_text);
    // }


    // public Scripture (string scriptureText)
    // {
    //     _text = scriptureText;
    // }

    // public void SetScriptureText(string text)
    // {
    //     _text = text;
    // }

}