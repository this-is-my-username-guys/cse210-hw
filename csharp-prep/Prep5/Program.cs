using System;
using System.Globalization;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favourite number: ");
        return int.Parse(Console.ReadLine());
    }

    static void PromptUserBirthYear(out int year)
    {
        Console.Write("Please enter your birth year: ");
        year=int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int num)
    {
        return num*num;
    }

    static void DisplayResult(string a, int b, int c)
    {
        Console.WriteLine($"{a}, the square of your number is {b}");
        Console.WriteLine($"{a}, you will turn {c} this year");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();

        string username = PromptUserName();
        int usernumber = PromptUserNumber();
        int birthyear; PromptUserBirthYear(out birthyear);
        int age = DateTime.Now.Year - birthyear;
        int square = SquareNumber(usernumber);

        DisplayResult(username,square,age);

    }
}