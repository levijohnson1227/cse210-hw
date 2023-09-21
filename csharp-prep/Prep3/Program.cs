using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please provide a random number: ");
        string magic = Console.ReadLine();
        int number = int.Parse(magic);

        int guess = -1;

        while (guess != number)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

        

            if (guess == number)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }
        }
    }
}