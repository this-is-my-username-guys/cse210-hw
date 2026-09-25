using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        string play="yes";
        do{
            Console.WriteLine("What is the magic number? ");
            int num= int.Parse(Console.ReadLine());
            int guess;
            int tries=0;
            do
            {
                Console.WriteLine("What is your guess? ");
                guess= int.Parse(Console.ReadLine());
                if (guess==num)
                {
                    tries++;
                    Console.WriteLine("You Guessed it");
                    Console.WriteLine($"You took {tries} guesses");
                }
                
                else if (guess>num)
                {
                    tries++;
                    Console.WriteLine("Lower");
                }

                else if (guess<num)
                {
                    tries++;
                    Console.WriteLine("Higher");
                }
            }while (guess!=num);

            Console.WriteLine("Would you like to play again? ");
            play=Console.ReadLine().ToLower();
        }while (play=="yes");
    }
}