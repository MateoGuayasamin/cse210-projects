using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    } 
    public void DisplayAll()
    {
        foreach(Entry e in _entries)
        e.Display();
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
            {
                foreach (Entry e in _entries)
                {
                    outputFile.WriteLine($"{e._date}|{e._prompText}|{e._entrytext}");
                }
            }        
    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                Entry newEntry = new Entry();
                newEntry._date = parts[0];
                newEntry._prompText = parts[1];
                newEntry._entrytext = parts[2];
                _entries.Add(newEntry);
            }
            
        }

    }

}    