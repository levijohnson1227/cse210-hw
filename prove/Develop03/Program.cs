using System;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", "3", "16");
        string referenceAsString = reference.CreateReference();
        string verse = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        // string verse = "This is a test";
        Scripture scripture = new Scripture(referenceAsString, verse);

        Console.WriteLine(scripture.DisplayReference());
        Console.WriteLine(scripture.DisplayScripture());
        string userInput = "";

        while (userInput != "quit" )
        {   
            Console.WriteLine();
            Console.WriteLine("Please press enter to Hide Words or type quit to exit.");
            string response = Console.ReadLine();
            
            if (scripture.IsCompletelyHidden() != true)
            {
                if (response == "")
                {
                    Console.Clear();
        
                    scripture.HideWords(scripture.DisplayScripture());
                    Console.WriteLine(scripture.DisplayReference());
                    Console.WriteLine(scripture.DisplayScripture());
                }
                else if (response == "quit")
                {
                    userInput = "quit";
                }
            }
            else
            {
                break;
            }
        }        
    }
}