using System;
using System.Runtime.CompilerServices;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                foreach (Entry entry in _entries)
                {
                    writer.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
                }
            }
            Console.WriteLine("Journal saved to file successfully.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error saving journal to file: {e.Message}");
        }
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();
        try
        {
            using (StreamReader reader = new StreamReader(file))
            {
                while (!reader.EndOfStream)
                {
                    string[] entryData = reader.ReadLine().Split(',');
                    if (entryData.Length == 3)
                    {
                        Entry entry = new Entry
                        {
                            _date = entryData[0],
                            _promptText = entryData[1],
                            _entryText = entryData[2]
                        };
                        _entries.Add(entry);
                    }
                }
            }
            Console.WriteLine("Journal loaded from file successfully.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error loading journal from file: {e.Message}");
        }
    }
}