using System;

class Program1
{
    static void Main(string[] args)
    {
        


        // Console.WriteLine("");
        // Console.WriteLine("Welcome to the scripture memorizer");
        //store scripture and reference

        // Word w1 = new Word("hello");
        // w1.GetDisplayText();
       
        //w1.GetDisplayText();

        
        Reference r1 = new Reference("Proverbs", 3, 5, 6);
        //Console.WriteLine(r1.GetReference());
        
        Scripture s1 = new Scripture(r1,"Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct they paths.");
        //Console.WriteLine(s1._words);

        Console.WriteLine(_words.HideRandomWords(3));
        

        
        //Console.WriteLine(s1.GetDisplayText());
        //clear console, display whole scripture and ref.
        //r1.GetReference();
        bool _isHidden = s1.IsCompletelyHidden();

        // while (_isHidden == false)
        // {
            Console.WriteLine("Welcome to Scripture Memorizer");
            Console.WriteLine("To continue press <Enter>, to quit type 'quit'.");
            string userInput = "quit";
            

            //string userQuit = Console.ReadLine();
        // while (userInput != "quit")
        // {

            // if (userQuit == "quit" || userQuit == "Quit")
            // {
            //     Console.WriteLine("Goodbye!");
            // }

             
            while (Console.ReadKey(true).Key == ConsoleKey.Enter && _isHidden == false)// add to 1st while loop?
            {
                r1.GetReference();

                s1.GetDisplayText();
                Console.Clear();
                s1.GetDisplayText();
                string newUserInput;//for sake of loop
                //_isHidden;


                
            }Console.WriteLine("Goodbye!");

                

                // else
                // {
                //     Console.WriteLine("Oops- entry is invalid.");
                // }
            
            
            

            //ConsoleKeyInfo userKey = Console.ReadKey();
            //if (userKey == ConsoleKey.Enter);

            //example from internet:
            //while(Console.ReadKey(true).Key != ConsoleKey.Enter);

           



            
        //}Console.WriteLine("Goodbye!");



        
        //Console.WriteLine(s1);
        
       //s1.GetDisplayText(); 

        //prompt user to press <Enter> or type "quit", <Enter> == continue, "quit" == end

        //<Enter> should hide few words of scripture, clear console, display again w/ hidden words
        //underscores should match number of letters in the word

        //program should continue prompting user and hiding words till all hidden => end
    } 
}