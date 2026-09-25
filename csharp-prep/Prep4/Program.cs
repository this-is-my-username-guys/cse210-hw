using System;

class Program
{
    static void Main(string[] args)
    {
        //using float in case program encounters a decimal. I like to improve my programs :)
        //I know it takes more space but this is a practice assignment so I did this for fun
        float temp = 0;
        float sum = 0;
        float average;
        float large;
        float? small = null;
        List<float> num = new List<float>();
        do
        {
            Console.Write("Enter Number: ");
            temp=float.Parse(Console.ReadLine());
            if(temp!=0)
            {
                num.Add(temp);
            }
        }while (temp!=0);
        
        num.Sort();
        
        foreach (float i in num)
        {
            sum+=i;
        }

        average = sum/num.Count;

        large=num[num.Count-1];

        foreach (float i in num)
        {
            if (i>0)
            {
                small=i;
                break;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}"); 
        Console.WriteLine($"The largest number is: {large}");

        if (small!=null)
        {
            Console.WriteLine($"The smallest positive number is: {small}");
        }
        else
        {
            Console.WriteLine("No positive number was entered.");
        }

        Console.WriteLine("The sorted list is: ");
        foreach (float i in num)
        {
            Console.WriteLine(i);
        }
    }
}