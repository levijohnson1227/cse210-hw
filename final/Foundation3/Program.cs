using System;

class Program
{
    static void Main(string[] args)
    {
        Address EV1 = new Address("405 S Washington St", "Johnson City", "MI", "USA");
        Address EV2 = new Address("326 N Nakuri Dr", "Athi River", "Nakuru", "Kenya");
        Address EV3 = new Address("729 W Sahuarita St", "Hondures", "Mexico City", "Mexico");

        Lecture lectureEV1 = new Lecture("Tech for the future", "A discussion on the innovations of AI and their effect on the western world.", DateTime.Now.AddDays(21), new TimeSpan(3,30,0),EV1, "Elon Zuckerburg", 200);
        Reception receptionEV2 = new Reception("Wedding: S&J", "The Wedding of Sam James and Tiffany Tanner.", DateTime.Now.AddDays(120), new TimeSpan(4,30,0),EV2,"samjames123@fakeemail.com");
        Outdoor outdoorEV3 = new Outdoor("Mexico Frisbee", "This is the annual Mexican ultimate frisbee tournament", DateTime.Now.AddDays(14), new TimeSpan(2,30,0),EV3,"Sunny with a chance of meetballs");

        Console.WriteLine("Marketing Messages:");
        Console.WriteLine();
        Console.WriteLine("Short Description:");
        Console.WriteLine(lectureEV1.DisplayShortDescription());
        Console.WriteLine("Full Description:");
        Console.WriteLine(lectureEV1.DisplayFullDetails());
        Console.WriteLine();
        Console.WriteLine("Short Description:");
        Console.WriteLine(receptionEV2.DisplayShortDescription());
        Console.WriteLine("Full Description:");
        Console.WriteLine(receptionEV2.DisplayFullDetails());
        Console.WriteLine();
        Console.WriteLine("Short Description:");
        Console.WriteLine(outdoorEV3.DisplayShortDescription());
        Console.WriteLine("Full Description:");
        Console.WriteLine(outdoorEV3.DisplayFullDetails());
        Console.WriteLine();



    }
    
}