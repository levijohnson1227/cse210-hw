using System.Diagnostics;

class Journal
{
    public List<Entry> newJournal = new List<Entry>();


    public void DisplayJournal()
    {
        Console.WriteLine("Journal Entries:");
        foreach (var entry in newJournal)
        {
            Console.WriteLine($"Date: {entry.DateTime}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Content: {entry.Content}");
            Console.WriteLine();
        }
    }
    
    public void SaveJournal(string fileName)
    {

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
           foreach (var entry in newJournal)
                {
                    outputFile.WriteLine($"Date: {entry.DateTime}");
                    outputFile.WriteLine($"Prompt: {entry.Prompt}");
                    outputFile.WriteLine($"Content: {entry.Content}");
                    outputFile.WriteLine();
                } 
        }
    }

    public void LoadJournal(string fileName)
    {
        var loadedJournal = new List<Entry>();
        using (StreamReader reader = new StreamReader(fileName))
        {
            Entry currentEntry = null;
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (line.StartsWith("Date: ") && currentEntry != null)
                {
                    currentEntry.DateTime = line.Substring("Date: ".Length);
                }
                else if (line.StartsWith("Prompt: ") && currentEntry != null)
                {
                    currentEntry.Prompt = line.Substring("Prompt: ".Length);
                }
                else if (line.StartsWith("Content: ") && currentEntry != null)
                {
                    currentEntry.Content = line.Substring("Content: ".Length);
                    loadedJournal.Add(currentEntry);
                    currentEntry = null;
                }
            }
            
        }
        newJournal = loadedJournal;
        Console.WriteLine("Journal loaded from file successfully.");
        
    }
    

    public void AddEntry()
    {
        string prompt = PromptGenerator.GeneratePrompt();
        Console.WriteLine(prompt);
        Console.Write("> ");
        string response = Console.ReadLine();

        Entry entry = new Entry
        {
            Prompt = prompt,
            Content = response,
            DateTime = DateTime.Now.ToShortDateString()
        };

        newJournal.Add(entry);
        Console.WriteLine("Entry added successfully.");

    }
}
