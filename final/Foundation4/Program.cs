using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activityList = new List<Activity>();

        activityList.Add(new Run(new DateTime(2023, 3, 11), 45, 4.5));
        activityList.Add(new Swim(new DateTime(2023, 3, 15), 30, 15));
        activityList.Add(new Cycle(new DateTime(2023, 3, 22), 60, 12.7));

        Console.WriteLine("Activity Summaries:");
        foreach (var activity in activityList)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}