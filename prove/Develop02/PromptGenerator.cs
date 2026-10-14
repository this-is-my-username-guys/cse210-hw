using System;
using System.Collections.Generic;

// Gives a random writing prompt.
// Every prompt gets used once before any of them repeat.
public class PromptGenerator
{
    private List<string> _prompts = new List<string>();
    private List<string> _unusedPrompts = new List<string>();
    private Random _random = new Random();

    public PromptGenerator()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("What is something small that made me smile today?");
        _prompts.Add("What is one thing I learned today?");
        _prompts.Add("Who did I help today, or who helped me?");
        _prompts.Add("What am I looking forward to tomorrow?");
        _prompts.Add("What is something I am grateful for right now?");
    }

    public string GetPrompt()
    {
        // When all prompts have been used, start over.
        if (_unusedPrompts.Count == 0)
        {
            _unusedPrompts.AddRange(_prompts);
        }

        int index = _random.Next(_unusedPrompts.Count);
        string prompt = _unusedPrompts[index];
        _unusedPrompts.RemoveAt(index);

        return prompt;
    }
}
