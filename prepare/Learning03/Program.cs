using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction[] fractions =
        {
            new Fraction(),
            new Fraction(5),
            new Fraction(3, 4),
            new Fraction(1, 3)
        };

        foreach (Fraction f in fractions)
        {
            Console.WriteLine(f.GetFractionString());
            Console.WriteLine(f.GetDecimalValue());
        }

        Random random = new Random();
        Fraction practice = new Fraction();
        int count = 1;

        while (count <= 20)
        {
            practice.SetTop(random.Next(1, 11));
            practice.SetBottom(random.Next(1, 11));

            Console.WriteLine($"Fraction {count}: string: {practice.GetFractionString()} Number: {practice.GetDecimalValue()}");
            count++;
        }
    }
}