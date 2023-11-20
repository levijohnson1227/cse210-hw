using System;
using System.Runtime.InteropServices;
using System.IO;
using System.Runtime.ExceptionServices;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> GoalList = new List<Goal>();

        string fileName = "goals.txt";

        int totalPoints = 0;

        string[] pointlines = System.IO.File.ReadAllLines(fileName);
        
        if (pointlines.Length > 0)
        {
            if (int.TryParse(pointlines[0], out int firstLineValue))
            {
                totalPoints = firstLineValue;
            }
        }


        int input = 0;

        while (input != 6)
        {
            Console.WriteLine($"You have {totalPoints} points.");

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Creat New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            input = Convert.ToInt32(Console.ReadLine());

            if (input != 6)
            {
                if (input == 1)
                {
                    Console.WriteLine("The Types of Goals are:");
                    Console.WriteLine("  1. Simple Goal");
                    Console.WriteLine("  2. Eternal Goal");
                    Console.WriteLine("  3. Checklist Goal");
                    Console.Write("Which type of goal would you like to create? ");
                    int goalInput = Convert.ToInt32(Console.ReadLine());
                    if (goalInput == 1)
                    {
                        string goalType = "Simple Goal";
                        Console.Write("What is the name of you goal? ");
                        string name = Console.ReadLine();
                        Console.Write("What is a short description of your goal? ");
                        string description = Console.ReadLine();
                        Console.Write("What is the amount of points you would like associtated with this goal? ");
                        int pointValue = Convert.ToInt32(Console.ReadLine());

                        SimpleGoal simpleGoal = new SimpleGoal(goalType, name, description, pointValue);
                        // simpleGoal.displayGoal();

                        GoalList.Add(simpleGoal);


                    }
                    else if (goalInput == 2)
                    {
                        string goalType = "Eternal Goal";
                        Console.Write("What is the name of you goal? ");
                        string name = Console.ReadLine();
                        Console.Write("What is a short description of your goal? ");
                        string description = Console.ReadLine();
                        Console.Write("What is the amount of points you would like associtated with this goal? ");
                        int pointValue = Convert.ToInt32(Console.ReadLine());

                        EternalGoal eternalGoal = new EternalGoal(goalType, name, description, pointValue);
                        // eternalGoal.displayGoal();

                        GoalList.Add(eternalGoal);

                    }
                    else if (goalInput == 3)
                    {
                        string goalType = "Checklist Goal";
                        Console.Write("What is the name of you goal? ");
                        string name = Console.ReadLine();
                        Console.Write("What is a short description of your goal? ");
                        string description = Console.ReadLine();
                        Console.Write("What is the amount of points you would like associtated with this goal? ");
                        int pointValue = Convert.ToInt32(Console.ReadLine());
                        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                        int maxTimesCompleted = Convert.ToInt32(Console.ReadLine());
                        Console.Write("What is the bonus points if accomplished that many times? ");
                        int bonusValue = Convert.ToInt32(Console.ReadLine());
                        

                        ChecklistGoal checklistGoal = new ChecklistGoal(goalType, name, description, pointValue, maxTimesCompleted, bonusValue);
                        // eternalGoal.displayGoal();

                        GoalList.Add(checklistGoal);

                    }
                }
                else if (input == 2)
                {
                    Console.WriteLine("The goals are:");
                    
                    int goalNumber = 1;
                    
                    foreach (var goal in GoalList)
                    {
                        Console.Write($"{goalNumber}. "); goal.displayGoalList();
                        goalNumber++;
                    }
                }
                else if (input == 3)
                {
                    using(StreamWriter outputfile = new StreamWriter(fileName))
                        {
                            outputfile.WriteLine(totalPoints);
                            
                            foreach (var goal in GoalList)
                            {
                                outputfile.WriteLine(goal.GetStringRepresentation());
                            }
                        }
                }
                else if (input == 4)
                {
                    string[] lines = System.IO.File.ReadAllLines(fileName);

                    foreach (string line in lines.Skip(1))
                    {
                        string[] parts = line.Split("|").Select(p => p.Trim()).ToArray();

                        if (parts.Length >= 4) 
                        {
                            string type = parts[0].Trim();
                            string name = parts[1].Trim();
                            string description = parts[2].Trim();
                            int points = int.Parse(parts[3].Trim());

                            if (type == "Simple Goal")
                            {
                                SimpleGoal simpleGoal = new SimpleGoal(type, name, description, points);
                                simpleGoal.displayGoalList();
                                GoalList.Add(simpleGoal);
                            }
                            else if (type == "Eternal Goal")
                            {
                                if(parts.Length == 4)
                                {
                                    EternalGoal eternalGoal = new EternalGoal(type, name, description, points);
                                    eternalGoal.displayGoalList();
                                    GoalList.Add(eternalGoal);
                                }
                                else if (parts.Length == 5)
                                {
                                    int timesCompleted = int.Parse(parts[4].Trim());
                                    EternalGoal eternalGoal = new EternalGoal(type, name, description, points, timesCompleted);
                                    eternalGoal.displayGoalList();
                                    GoalList.Add(eternalGoal);
                                }
                            }
                            else if (type == "Checklist Goal" && parts.Length >= 6)
                            {
                                if(parts.Length == 6)
                                {
                                    int maxCompleted = int.Parse(parts[4].Trim());
                                    int bonus = int.Parse(parts[5].Trim());
                                    ChecklistGoal checklistGoal = new ChecklistGoal(type, name, description, points, maxCompleted, bonus);
                                    checklistGoal.displayGoalList();
                                    GoalList.Add(checklistGoal);
                                }
                                if(parts.Length == 7)
                                {
                                    int maxCompleted = int.Parse(parts[4].Trim());
                                    int bonus = int.Parse(parts[5].Trim());
                                    int timesCompleted = int.Parse(parts[6].Trim());
                                    ChecklistGoal checklistGoal = new ChecklistGoal(type, name, description, points, maxCompleted, bonus, timesCompleted);
                                    checklistGoal.displayGoalList();
                                    GoalList.Add(checklistGoal);
                                }
                            }

                        }
                    }
                }

                else if (input == 5)
                {
                    Console.WriteLine("The goals are: ");
                    int goalNumber = 1;

                    foreach (var goal in GoalList)
                    {
                        Console.Write($"{goalNumber}. "); goal.DisplayGoalName();
                        goalNumber++;
                    }
                    int recordInput = Convert.ToInt32(Console.ReadLine());
                    
                    if (recordInput >= 1 && recordInput <= GoalList.Count)
                    {
                        Goal selectedGoal = GoalList[recordInput - 1];

                        int eventPoints = selectedGoal.RecordEvent();

                        totalPoints = totalPoints + eventPoints;

                        Console.WriteLine($"Congrats you have earned {eventPoints}");
                        Console.WriteLine();  
                        
                    }
                    

                }

            }
        }
    }
}
