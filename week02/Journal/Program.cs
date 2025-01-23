using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        int userChoice = 0;
        PromptGenerator pGen = new PromptGenerator();
        Journal journal = new Journal();
        Entry newEntry = new Entry();
        

        do//do while works, DON'T TOUCH
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to your Journal app!");
            Console.WriteLine("Choose a number from the menu:");
            Console.WriteLine("1. New Entry");
            Console.WriteLine("2. Display Entries");
            Console.WriteLine("3. Save to File");
            Console.WriteLine("4. Load From File");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            int newChoice = int.Parse(Console.ReadLine());
            userChoice = newChoice;
            
            
            if (userChoice == 1)//works don't touch//
            {
                Entry newEntry2 = new Entry();
                
                newEntry2._randomPrompt = pGen.GetRandomPrompt();
                Console.WriteLine(newEntry2._randomPrompt);
                Console.Write("> ");
                
                newEntry2._response = Console.ReadLine();
                newEntry = newEntry2;
                journal.AddEntry(newEntry);
                
                //newEntry.DisplayEntry();
                //journal.DisplayJournalEntries();//WORKS HERE, NOT IN NEXT IF

                //Console.WriteLine(journal._entries.Count());

            }


            if (userChoice == 2)//works DON'T TOUCH
            {
               
                int numberEntries = journal._entries.Count();
                //Console.WriteLine(numberEntries);
                //newEntry.DisplayEntry();
                if (numberEntries == 0)
                {
                    Console.WriteLine("There are no entries.");
                }

                else
                {
                    journal.DisplayJournalEntries();
                }
            }

            if (userChoice == 3)//SEEMS TO WORK...entries are "Entry"
            {
               //List<Entry> _entries;
                //Console.WriteLine("What would you like to name the file?");
                //string fileName = Console.ReadLine();


                journal.SaveToFile(journal._entries);
            }

            if (userChoice == 4)//loads "Entry" from file, but cant add to it
            {
                Console.WriteLine("What is the name of the file you want to load?");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);

                //add menu inside local bracket so can add to it?

            }
            
        

        }while (userChoice !=5);//5 works and closing works, don't touch//
            
        Console.WriteLine("Have a nice Day! Goodbye.");
        
    }
}

//if no entries then show "no entries"