using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("The journal is empty.");
            Console.WriteLine();
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void Search(string word)
    {
        int count = 0;

        foreach (Entry entry in _entries)
        {
            if (entry.HasWord(word))
            {
                entry.Display();
                count = count + 1;
            }
        }

        Console.WriteLine($"Entries found: {count}");
        Console.WriteLine();
    }

    public void SaveToFile(string filename)
    {
        List<string> lines = new List<string>();

        foreach (Entry entry in _entries)
        {
            lines.Add(entry.ToFileLine());
        }

        File.WriteAllLines(filename, lines);
    }

    public void LoadFromFile(string filename)
    {
        // Read the whole file first so a bad file does not erase the journal.
        string[] lines = File.ReadAllLines(filename);
        List<Entry> newEntries = new List<Entry>();

        foreach (string line in lines)
        {
            if (line.Trim() == "")
            {
                continue;
            }

            string[] parts = line.Split("~|~");

            if (parts.Length != 4)
            {
                throw new Exception("A line in the file is not in the right format.");
            }

            newEntries.Add(new Entry(parts[0], parts[1], parts[2], parts[3]));
        }

        _entries = newEntries;
    }
}
