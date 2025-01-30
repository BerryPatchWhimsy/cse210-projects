using System;
using System.Collections.Generic;
public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;


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

    public bool IsCompletelyHidden()//needs work
    {
        //bool _isHidden;
        Word w1 = new Word("");

        // foreach (Word word in _words)
        // {
        //     if (word.IsHidden() == false)
        //     {
        //         _isHidden = false;
        //     }

        //     if (word.IsHidden() == true)
        //     {
        //         _isHidden = true;
        //     }
        // }
        // return _isHidden;

        
        
        int v = _words.Count;
        
        for (int i=0; i < v; i++)

            
            while (w1.IsHidden() == true)
            {
                return true;
            }
            return false;
 
    }


    public string GetDisplayText()
    {
        //display reference and scripture with hidden words

        //_reference.GetReference();

        string referenceText = _reference.GetReference();//leave alone
        //Word.GetDisplayText();



    
        foreach (Word word in _words)
        {
            
            //example from internet:
            // foreach (string a in wordList) 
            // {
            //   string newList = a.Replace(randomWords, "_");
            //   Console.Write(newList);
            //   Console.Write(" ");
            // }


            //Console.Write($"{word.GetDisplayText()} ");//doubles words
            //HideRandomWords(3);
            word.GetDisplayText();//single words
        }

        //need add random hide

        //HideRandomWords(3);
        
        
        //return $"{referenceText} - {_words}";//returns words, reference, list trail
       //return referenceText;//returns words, reference
       return ""; //returns words 

        // _reference.GetReference();
        
        

    }
    

    // 

}