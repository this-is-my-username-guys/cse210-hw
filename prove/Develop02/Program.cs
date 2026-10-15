using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool keepGoing = true;

        Console.WriteLine("Welcome to the Journal Program!");

        while (keepGoing)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Search");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                WriteEntry(journal, promptGenerator);
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                LoadJournal(journal);
            }
            else if (choice == "4")
            {
                SaveJournal(journal);
            }
            else if (choice == "5")
            {
                SearchJournal(journal);
            }
            else if (choice == "6")
            {
                keepGoing = false;
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Please type a number from 1 to 6.");
                Console.WriteLine();
            }
        }
    }

    static void WriteEntry(Journal journal, PromptGenerator promptGenerator)
    {
        string prompt = promptGenerator.GetPrompt();
        Console.WriteLine(prompt);
        Console.Write("> ");
        string response = Console.ReadLine();

        string mood = AskForMood();
        string date = DateTime.Now.ToShortDateString();

        Entry entry = new Entry(date, prompt, response, mood);
        journal.AddEntry(entry);

        Console.WriteLine("Entry added.");
        Console.WriteLine();
    }

    static string AskForMood()
    {
        string mood = "";

        while (mood != "1" && mood != "2" && mood != "3" && mood != "4" && mood != "5")
        {
            Console.Write("How are you feeling (1 = low, 5 = great)? ");
            mood = Console.ReadLine();
        }

        return mood;
    }

    static void LoadJournal(Journal journal)
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();

        try
        {
            journal.LoadFromFile(filename);
            Console.WriteLine("Journal loaded.");
        }
        catch (Exception error)
        {
            Console.WriteLine($"Could not load the file: {error.Message}");
        }

        Console.WriteLine();
    }

    static void SaveJournal(Journal journal)
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();

        try
        {
            journal.SaveToFile(filename);
            Console.WriteLine("Journal saved.");
        }
        catch (Exception error)
        {
            Console.WriteLine($"Could not save the file: {error.Message}");
        }

        Console.WriteLine();
    }

    static void SearchJournal(Journal journal)
    {
        Console.Write("Type a word or date to search for: ");
        string word = Console.ReadLine();
        Console.WriteLine();

        journal.Search(word);
    }
}
