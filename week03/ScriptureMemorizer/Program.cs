using System;

class Program1
{
    static void Main(string[] args)
    {
        //store scripture and reference
        Reference r1 = new Reference("Proverbs", 3, 5, 6);
        
        Scripture s1 = new Scripture(r1,"Hello world this is the scripture text");
        
        //clear console, display whole scripture and ref.
        Console.WriteLine(r1);
        Console.WriteLine(s1);

        //prompt user to press <Enter> or type "quit", <Enter> == continue, "quit" == end

        //<Enter> should hide few words of scripture, clear console, display again w/ hidden words
        //underscores should match number of letters in the word

        //program should continue prompting user and hiding words till all hidden => end
    } 
}