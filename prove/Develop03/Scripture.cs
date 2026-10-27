using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] parts = text.Split(' ');
        foreach (string part in parts)
        {
            Word word = new Word(part);
            _words.Add(word);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            List<Word> visibleWords = new List<Word>();
            foreach (Word word in _words)
            {
                if (word.IsHidden() == false)
                {
                    visibleWords.Add(word);
                }
            }

            if (visibleWords.Count == 0)
            {
                return;
            }

            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
        }
    }

    public void ShowOneRandomWord()
    {
        List<Word> hiddenWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                hiddenWords.Add(word);
            }
        }

        if (hiddenWords.Count > 0)
        {
            int index = _random.Next(hiddenWords.Count);
            hiddenWords[index].Show();
        }
    }

    public int GetTotalWords()
    {
        return _words.Count;
    }

    public int GetHiddenWords()
    {
        int count = 0;
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                count++;
            }
        }
        return count;
    }

    public bool IsCompletelyHidden()
    {
        return GetHiddenWords() == GetTotalWords();
    }

    public string GetDisplayText()
    {
        string text = _reference.GetDisplayText() + " ";

        foreach (Word word in _words)
        {
            text = text + word.GetDisplayText() + " ";
        }

        return text;
    }
}
