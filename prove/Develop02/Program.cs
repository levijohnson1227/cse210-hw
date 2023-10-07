using System;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Journal journal = new Journal();

        bool continueRunning = true;
        while (continueRunning)
        {
           Console.WriteLine("Please select one of the prompts" );
           Console.WriteLine("1. Write a new entry"); 
           Console.WriteLine("2. Display the journal"); 
           Console.WriteLine("3. Save the journal to a file"); 
           Console.WriteLine("4. Load the journal from a file"); 
           Console.WriteLine("5. Exit"); 
           
           string choice = Console.ReadLine();

           if (choice == "1")
           {
                journal.AddEntry();
           }
           else if (choice == "2")
           {
                journal.DisplayJournal();
           }
           else if (choice == "3")
           {
                Console.Write("Enter a filename to save the journal: ");
                string saveFileName = Console.ReadLine();
                journal.SaveJournal(saveFileName);    
           }
           else if (choice == "4")
           {
                Console.Write("Enter a filename to Load the journal from: ");
                string loadFileName = Console.ReadLine();
                journal.LoadJournal(loadFileName);  
           }
           else if (choice == "5")
           {
                continueRunning = false;
           }
           else
           {
                Console.WriteLine("Invalid choice. Please enter a valid option.");
           }

        }

    }
}