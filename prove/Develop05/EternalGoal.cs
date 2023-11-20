using System.ComponentModel.DataAnnotations;

public class EternalGoal : Goal
{
    private int _timesCompleted;

    public EternalGoal(string type, string name, string description, int points) : base(type, name, description, points)
    {

    }
    public EternalGoal(string type, string name, string description, int points, int timesCompleted) : base(type, name, description, points)
    {
        _timesCompleted = timesCompleted;
    }

    public override string GetStringRepresentation()
    {
         return $"{_type} | {_goalName} | {_goalDescription} | {_points} | {_timesCompleted} ";
    }

    public override void displayGoalList()
    {
        Console.Write(IsComplete()); Console.WriteLine($" {_goalName} ({_goalDescription}) -- Currently completed {_timesCompleted} times.");
    }

    public override string IsComplete()
    {
        string markerString = "";
        
        if (_timesCompleted >= 1)
        { 
            markerString = "[X]";
            return markerString;
        }
        else
        {
            markerString = "[ ]";
            return markerString;
        }
    }

    public override int RecordEvent()
    {
        _timesCompleted++;
        _totalPoints = _points + _totalPoints;
        return _totalPoints;
    }
}