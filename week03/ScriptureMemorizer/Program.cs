using System;
//I tried to add a few things to just make it easier for the user to read from the console. Like
//putting the reference on a line by itself and the welcome message set apart by a blank line when the 
//program starts.

class Program1
{
    static void Main(string[] args)
    {

        //must store a scripture with reference and text, allow for multiple verses
        Reference r1 = new Reference("Proverbs", 3, 5, 6);
        Console.WriteLine(r1.GetReference());
        
        Scripture s1 = new Scripture(r1,"Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct they paths.");
            //Console.WriteLine(s1._words);


        //clear console and display complete scripture- reference and text
        Console.Clear();
        Console.WriteLine($"{r1.GetReference()} ");
        s1.GetDisplayText();
            

        //prompt user to press<enter> or type "quit"
        Console.WriteLine("");
        Console.WriteLine("\nWelcome to Scripture Memorizer");
        Console.Write("To continue press <Enter>, to quit type 'quit'.");
        string userInput = Console.ReadLine();

        //quit = end
        //<enter> = hide random words, clear console, display new scripture 
        //with hidden words as underscores
        //if <enter> continue hide, clear, display till all hidden- then end
            
        while (Console.ReadKey(true).Key == ConsoleKey.Enter && userInput != "quit")
        {
            //string UserInput = Console.ReadLine();
            if (s1.IsCompletelyHidden() == false) //&& UserInput != "quit")
            {
                s1.HideRandomWords(3);
                Console.Clear();
                s1.GetDisplayText();
                //string UserInput = Console.ReadLine();
            }

            else
            {
                Console.WriteLine("\nGoodbye!");
            }

        }Console.WriteLine("\nGoodbye!");
        


    } 
}