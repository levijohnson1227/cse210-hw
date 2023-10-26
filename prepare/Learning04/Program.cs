using System;

class Program
{
    static void Main(string[] args)
    {
        Assignmnet assignment1 = new Assignmnet("Levi Johnson", "Calculus I");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Levi Johnson", "Calculus I", "8","10-35");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment("Levi Johnson", "New Testament", "Finding the savior Jesus Christ");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}