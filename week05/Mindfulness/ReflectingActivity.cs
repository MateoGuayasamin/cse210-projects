public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity(string name, string description):base(name,description)
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }
    public void Run()
    {
        base.DisplayingStartingMessage();
        base.ShowSpinner(10);
        Console.WriteLine("Consider the following prompt:");
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
        Console.Write("You may begin in:");
        ShowCountDown(5);
        Console.WriteLine("");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            DisplayQuestion();
            base.ShowSpinner(8);
            Console.WriteLine();
        }
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int i =random.Next(_prompts.Count);
        string randompront =$"--- {_prompts[i]} ---";
        return randompront;
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int q =random.Next(_prompts.Count);
        string randomQuestion = $"{_questions[q]}";
        return randomQuestion;
    }
    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }
    public void DisplayQuestion()
    {
        Console.Write(GetRandomQuestion());
    }

}