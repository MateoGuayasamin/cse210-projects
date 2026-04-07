public class Assigment
{
    private string _studentName;
    private string _topic;

    public Assigment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }   
     public string GetSummary()
    {
        string summary = $"{_studentName} - {_topic}";
        return summary;
    } 
}
