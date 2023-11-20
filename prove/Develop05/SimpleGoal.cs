public class SimpleGoal : Goal
{
    private bool _complete = false;

    public SimpleGoal(string type, string name, string description, int points) : base(type, name, description, points)
    {

    }

    public override string GetStringRepresentation()
    {
         return $"{_type} | {_goalName} | {_goalDescription} | {_points} ";
    }
    public override void displayGoalList()
    {
        Console.Write(IsComplete()); Console.WriteLine($" {_goalName} ({_goalDescription})");
    }

    public override string IsComplete()
    {
        string markerString = "";
        
        if (_complete == true)
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
        _complete = true;
        _totalPoints = _points + _totalPoints;
        return _totalPoints;
    }
    
}