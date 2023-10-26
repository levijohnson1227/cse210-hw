public class WritingAssignment : Assignmnet
{
    private string _title {get; set;}

    public WritingAssignment(string student, string topic, string title) : base(student, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string studentName = GetStudnetName();
        return $"{_title} by {studentName}";
    }
}