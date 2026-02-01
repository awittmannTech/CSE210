
using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public Journal Load()
    {
        Console.WriteLine("Enter journal file name: ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        
        Journal loadedJournal = new Journal();

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            Entry loadedEntry = new Entry();
            loadedEntry._date = parts[0];
            loadedEntry._prompt = parts[1];
            loadedEntry._userInput = parts[2];

            loadedJournal._entries.Add(loadedEntry);
        }

        return loadedJournal;
    }

    public void Save()
    {
        Console.Write("Enter new file name: ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine("date, prompt, entry");
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}, ${entry._prompt}, ${entry._userInput}");
            }
        } 
    }

    public void DisplayEntries()
    {
         foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void MakeEntry()
    {
        PromptGen gen = new PromptGen();
        string randomPrompt = gen.GenerateRandomPrompt();

        Console.Write($"{randomPrompt} ");
        string userInput = Console.ReadLine();

        Entry newEntry = new Entry();
        newEntry._date = 
    }
}