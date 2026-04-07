using System.Runtime.InteropServices;

public class MathAssigment: Assigment
{
    private string _textBookSection;
    private string _problem;

    public MathAssigment(string name, string topic, string textBook, string problem ): base(name, topic)
    {
        _textBookSection = textBook;
        _problem = problem;
    }

    public string GetHomeworkList()
    {
        string summary = base.GetSummary();
        string hmwrk = $"{summary}, Section:{_textBookSection}, Problems:{_problem}";
        return hmwrk;
    }
}