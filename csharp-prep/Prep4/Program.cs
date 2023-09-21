using System;
using System.Globalization;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number = -1;

        while (number !=0)
        {
           Console.Write("Enter a number: ");
           number = int.Parse(Console.ReadLine());

           if (number != 0)
           {
            numbers.Add(number);
           } 
        } 
        Console.WriteLine(numbers);
    }
}