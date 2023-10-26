using System.Runtime.CompilerServices;

public class MathAssignment : Assignmnet
{
    private string _textbookSection {get; set;}
    private string _problems {get; set;}

    public MathAssignment(string student, string topic, string section, string problems) : base(student, topic)
    {
        _problems = problems;
        _textbookSection = section;
        
    }

    public string GetHomeworkList()
    {
        return $"Section: {_textbookSection} Problems: {_problems}";
    }
}