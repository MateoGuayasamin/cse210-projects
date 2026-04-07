public class WritingAssignment : Assigment
{
    private string _title;

    public WritingAssignment (string name, string topic, string title ): base(name, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string summary = base.GetSummary();
        string writing = $"{summary}, {_title}";
        return writing;
    }
}