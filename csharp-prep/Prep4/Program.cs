using System;
using System.Globalization;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        List<int> usernumbers = new List<int>();
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number = -1;

        while (number !=0)
        {
           Console.Write("Enter a number: ");
           number = int.Parse(Console.ReadLine());

           if (number != 0)
           {
            usernumbers.Add(number);
           } 
        } 
        
        int sum = 0;
        foreach (int usernumber in usernumbers)
        {
            sum += usernumber;
        }

        Console.WriteLine($"The sum of the numbers is: {sum}");

        double average = ((double)sum) / usernumbers.Count;
        Console.WriteLine($"The average of the numbers is: {average}");

        int largest = usernumbers[0];

        foreach (int usernumber in usernumbers)
        {
            if(usernumber > largest)
            {
                largest = usernumber;
            }
        }

        Console.WriteLine($"The largest number is: {largest}");


    }
}