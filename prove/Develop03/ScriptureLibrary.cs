using System;

public class ScriptureLibrary
{
    private List<Scripture> _scriptures = new List<Scripture>();
    private Random _random = new Random();

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename) == false)
        {
            return;
        }

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            if (parts.Length == 5)
            {
                string book = parts[0];
                int chapter = int.Parse(parts[1]);
                int startVerse = int.Parse(parts[2]);
                int endVerse = int.Parse(parts[3]);
                string text = parts[4];

                Reference reference;
                if (startVerse == endVerse)
                {
                    reference = new Reference(book, chapter, startVerse);
                }
                else
                {
                    reference = new Reference(book, chapter, startVerse, endVerse);
                }

                _scriptures.Add(new Scripture(reference, text));
            }
        }
    }

    public void AddDefaultScriptures()
    {
        Reference reference1 = new Reference("John", 3, 16);
        string text1 = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        _scriptures.Add(new Scripture(reference1, text1));

        Reference reference2 = new Reference("Proverbs", 3, 5, 6);
        string text2 = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        _scriptures.Add(new Scripture(reference2, text2));
    }

    public int GetCount()
    {
        return _scriptures.Count;
    }

    public Scripture GetRandomScripture()
    {
        int index = _random.Next(_scriptures.Count);
        return _scriptures[index];
    }
}
