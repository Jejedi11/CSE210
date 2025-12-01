public class WritingAssignment : Assignment
{
    private string _title;
    
    public string GetWritingInfo()
    {
        return $"{_title} by {GetStudentName()}";
    }

    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }
}