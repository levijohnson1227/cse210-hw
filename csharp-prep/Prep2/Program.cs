using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your grade percentage? ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);

        string lettergrade = "";

        if (number >= 90)
        {
            lettergrade = "A";
        }
        else if (number >= 80)
        {
            lettergrade = "B";
        }
        else if (number >= 70)
        {
            lettergrade = "C";
        }
        else if (number >= 60)
        {
            lettergrade = "D";
        }
        else
        {
            lettergrade = "F";
        }

        Console.WriteLine($"Your letter grade is {lettergrade}");

        if (number >= 70)
        {
            Console.WriteLine("Awesome, you passed!");
        }
        else
        {
            Console.WriteLine("Sadly you failed.");
        }
    }
}