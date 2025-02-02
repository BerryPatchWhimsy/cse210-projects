using System;
using System.Collections.Generic;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();


    //constructor with parameters: Reference, string text
        //convert string to Word objects
    public Scripture(Reference reference, string _texts)
    {
        //break _text string into Word objects and add to list
        _reference = reference;

        string [] words = _texts.Split(" ");
        
        foreach (string word in words)
        {
            Word w1 = new Word(word);
            _words.Add(w1);
        }
            
    }

    //hide random words, with parameter: number to hide
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


    // public void DisplayWordListText()
    // {
    //     foreach (Word word in _words)
    //     {
    //         Console.Write($"{word.GetDisplayText()} ");//doubles words
    //         //word.GetDisplayText();//single words
            
    //     }
        
    // }

    


    //get display text as a string. needs to have text and underscores
    public string GetDisplayText()
    {
        //display reference and scripture with hidden words

        //_reference.GetReference();

        string referenceText = _reference.GetReference();//leave alone
        //Word.GetDisplayText();

        foreach (Word word in _words)
        {
            
            //Console.Write($"{word.GetDisplayText()} ");//doubles words
            _reference.GetReference();
            word.GetDisplayText();//single words
        }

        
        //return $"{referenceText} - {_words}";//returns words, reference, list trail
       //return referenceText;//returns words, reference
       return ""; //returns words 

    }

    //check to see if the scripture is completely hidden. If true, end program
    public bool IsCompletelyHidden()//needs work
    {
        // //bool _isHidden;
        Word w1 = new Word("");

        // foreach (Word word in _words)
        // {
        //     if (word.IsHidden() == false)
        //     {
        //         //_isHidden = false;
        //         return false;
        //     }

        //     else
        //     {
        //         //_isHidden = true;
        //         return true;
        //     }

        // }
        

        
        
        int v = _words.Count;
        
        for (int i=0; i < v; i++)

            
            while (w1.IsHidden() == true)
            {
                return true;
            }
            return false;
 
    }

}