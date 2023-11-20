using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _maxCompleted;

    private int _bonus;

    public ChecklistGoal(string type, string name, string description, int points, int maxCompleted, int bonus, int timesCompleted) : base(type, name, description, points)
    {
        _maxCompleted = maxCompleted;
        _bonus = bonus;
        _timesCompleted = timesCompleted;
    }
    public ChecklistGoal(string type, string name, string description, int points, int maxCompleted, int bonus) : base(type, name, description, points)
    {
        _maxCompleted = maxCompleted;
        _bonus = bonus;
    
    }

    public override string GetStringRepresentation()
    {
         return $"{_type} | {_goalName} | {_goalDescription} | {_points} | {_maxCompleted} | {_bonus} | {_timesCompleted}";
    }
    public override void displayGoalList()
    {
        Console.Write(IsComplete()); Console.WriteLine($" {_goalName} ({_goalDescription}) -- Currently completed {_timesCompleted}/{_maxCompleted}.");
    }

    public override string IsComplete()
    {
        string markerString = "";
        
        if (_timesCompleted == _maxCompleted)
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
        if (_timesCompleted == _maxCompleted)
        { 
            _totalPoints = _bonus + _totalPoints;
        }

        return _totalPoints;
    }

}