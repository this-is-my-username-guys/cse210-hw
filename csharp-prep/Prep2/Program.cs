using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        int percent= int.Parse(Console.ReadLine());
        string grade;
        int last_digit=percent%10;
        string sign;
        if (percent >= 90)
        {
            grade="A";
        }

        else if (percent >= 80)
        {
            grade="B";
        }

         else if (percent >= 70)
        {
            grade="C";
        }

         else if (percent >= 60)
        {
            grade="D";
        }

        else
        {
            grade="F";
        }

        if(last_digit>=7)
        {
            if(grade=="A" || grade=="F")
            {
                sign=null;
            }
            else
            {
                sign="+";
            }
            
        }
        
        else if(last_digit<3)
        {
            if(grade=="F")
            {
                sign=null;
            }
            else
            {
                sign="-";
            }
        }

        else
        {
            sign=null;
        }

        Console.WriteLine($"Your letter grade is: {grade}{sign}");

        if (percent>=70)
        {
            Console.WriteLine("Congratulations, You passed!");
        }

        else
        {
            Console.WriteLine("Sorry, You failed. Better luck next time!");
        }
    }
}