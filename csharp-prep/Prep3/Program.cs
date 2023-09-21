using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please provide a random number: ");
        string magic = Console.ReadLine();
        int number = int.Parse(magic);

        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        int guessednumber = int.Parse(guess);

        if (guessednumber == number)
        {
            Console.WriteLine("You guessed it!");
        }
        else if (guessednumber < number)
        {
            Console.WriteLine("Higher");
        }
        else
        {
            Console.WriteLine("Lower");
        }

    }
}