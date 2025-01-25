using System;
public class Scripture
{
    public List<Word> _words = new List<Word>();
    public Reference _reference;


    public Scripture(Reference reference, string _texts)
    {
        //break _text string into Word objects and add to list?

        string [] word = _texts.Split(" ");
        string script = word[0];

        foreach (char text in _texts)
        {
            Word w1 = new Word($"{script}");
            _words.Add(w1);
        }
        
        Console.WriteLine($"{reference}- {_words}");
    }

    public void HideRandomWords(int numberToHide)
    {
        int v = numberToHide;
        for (int i=0; i < v; i++)
        {
            Random randomGenerator = new Random();
            int index = randomGenerator.Next(_words.Count);
            Word _randomWord = _words[index];
            _randomWord.Hide();

        }
    }

    

    public string GetDisplayText()
    {
        //display reference and scripture with hidden words


        Reference r1 = new Reference();
        string refText = r1.GetReferenceVerses();

        Scripture s1 = new Scripture(r1, "");

        s1.HideRandomWords(3);

        //HideRandomWords(3);

        return $"{refText} - {s1}";

    }

    public bool IsCompletelyHidden()
    {
        int v = _words.Count;

            Word w1 = new Word("");
            while (w1.IsHidden() == true)
            {
                return true;
            }
            return false;
 
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