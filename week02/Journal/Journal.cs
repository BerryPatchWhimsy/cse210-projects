using System.IO;
using System.Collections.Generic;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)//works DON'T TOUCH
    {
        _entries.Add(newEntry);
    }

    public void DisplayJournalEntries()//works DON'T TOUCH
    {
        foreach (Entry e in _entries)
        {
            //Console.WriteLine(entry);
            e.DisplayEntry();
        }
    }

    public void SaveToFile(List<Entry> entries)//DOESN'T SAVE ACTUAL TEXT, only shows class
    //doesn't add entry to file, only overwrites, use entry.ToString()
    {
        Console.WriteLine("What would you like to name the file? ");
        string fileName = Console.ReadLine();
        
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            //outputFile.WriteLine("Journal Entries: ");
            
            foreach (Entry e in entries)
            {

                outputFile.WriteLine(e.SaveToString());//still shows "Entry"
                //DisplayJournalEntries();
            }
            
        }
    }

    public void LoadFromFile(string fileName)
    {
        Console.WriteLine("Reading from file ...");
        //string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(fileName);


        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string entry = parts[0];

            Console.WriteLine(entry);
            
        }

    }

}