using System.IO;
using System.Collections.Generic;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
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

    public void SaveToFile( string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {

            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry);
            }
            // // You can add text to the file with the WriteLine method
            //         outputFile.WriteLine("This will be the first line in the file.");
    
            // // You can use the $ and include variables just like with Console.WriteLine
            //         string color = "Blue";
            //         outputFile.WriteLine($"My favorite color is {color}");
            //     }
        }
    }

    public void LoadFromFile(string fileName)
    {
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