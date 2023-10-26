public class Assignmnet
{
    private string _studentName { get; set; }
    private string _topic {get; set;}

    public Assignmnet(string student, string topic)
    {
        _studentName = student;
        _topic = topic;

    }

    public string GetSummary()
    {
        string Summary = $"{_studentName} - {_topic}";


        return Summary;
    }

    public string GetStudnetName()
    {
        return _studentName;
    }
}