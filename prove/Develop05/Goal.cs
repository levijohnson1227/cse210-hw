public class Goal
{
    protected int _points;
    protected string _type;
    protected string _goalDescription;
    protected string _goalName;
    protected int _totalPoints;

    private bool _complete;


    public Goal(string type, string name, string description, int points)
    {
        _type = type;
        _goalDescription = description;
        _goalName = name;
        _points = points;
    }
    public virtual string GetStringRepresentation()
    {
         return $"{_type} | {_goalName} | {_goalDescription} | {_points} ";
    }

    public virtual void displayGoalList()
    {
        Console.Write(IsComplete()); Console.WriteLine($" {_goalName} ({_goalDescription})");
    }


    public virtual string IsComplete()
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

    public virtual int RecordEvent()
    {
        _complete = true;
        _totalPoints = _points + _totalPoints;
        return _totalPoints;
    }
    public void DisplayGoalName()
    {
        Console.WriteLine(_goalName);
    }


}

