using System;

// An Entry is one journal entry: a date, a prompt, a response, and a mood.
public class Entry
{
    private string _date;
    private string _prompt;
    private string _response;
    private string _mood;

    public Entry(string date, string prompt, string response, string mood)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
        _mood = mood;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} | Mood: {_mood}/5");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine();
    }

    // Turns the entry into one line of text for the file.
    public string ToFileLine()
    {
        return $"{_date}~|~{_prompt}~|~{_response}~|~{_mood}";
    }

    // Checks if the word is found anywhere in this entry.
    public bool HasWord(string word)
    {
        string lowerWord = word.ToLower();

        if (_date.ToLower().Contains(lowerWord))
        {
            return true;
        }
        if (_prompt.ToLower().Contains(lowerWord))
        {
            return true;
        }
        if (_response.ToLower().Contains(lowerWord))
        {
            return true;
        }
        return false;
    }
}