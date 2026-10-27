using System;

// EXCEEDING REQUIREMENTS
// 1. The program has a library of scriptures loaded from a file (scriptures.txt)
//    and picks one at random each time. If the file is missing, it uses
//    two built-in scriptures.
// 2. Stretch challenge: only words that are not already hidden are picked.
// 3. The user chooses a difficulty (Easy, Medium, Hard) to decide how many
//    words are hidden each time.
// 4. The user can type "hint" to show one hidden word again.
// 5. The screen shows how many words are hidden.
class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary library = new ScriptureLibrary();
        library.LoadFromFile("scriptures.txt");

        if (library.GetCount() == 0)
        {
            library.AddDefaultScriptures();
        }

        Scripture scripture = library.GetRandomScripture();

        int wordsToHide = ChooseDifficulty();

        string input = "";
        while (input != "quit")
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine($"Hidden words: {scripture.GetHiddenWords()} of {scripture.GetTotalWords()}");

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine();
                Console.WriteLine("All words are hidden. Great job!");
                return;
            }

            Console.WriteLine();
            Console.Write("Press enter to continue, type 'hint' for help, or type 'quit': ");
            input = Console.ReadLine();

            if (input == null)
            {
                input = "quit";
            }
            input = input.ToLower();

            if (input == "hint")
            {
                scripture.ShowOneRandomWord();
            }
            else if (input != "quit")
            {
                scripture.HideRandomWords(wordsToHide);
            }
        }
    }

    static int ChooseDifficulty()
    {
        Console.Clear();
        Console.WriteLine("Choose a difficulty:");
        Console.WriteLine("1. Easy (hide 2 words at a time)");
        Console.WriteLine("2. Medium (hide 4 words at a time)");
        Console.WriteLine("3. Hard (hide 8 words at a time)");
        Console.Write("Enter 1, 2, or 3: ");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            return 2;
        }
        else if (choice == "3")
        {
            return 8;
        }
        else
        {
            return 4;
        }
    }
}
