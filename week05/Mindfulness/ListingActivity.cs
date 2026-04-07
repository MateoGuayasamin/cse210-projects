public class ListingActivity : Activity
{
    private int _count;
    public List<string> _prompts = new List<string>();

    public ListingActivity(string name, string description): base(name,description)
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }
    public void Run()
    {
        base.DisplayingStartingMessage();
        base.ShowSpinner(10);
        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in:");
        ShowCountDown(5);
        Console.WriteLine();

        List<string> userList = GetListFromUser();
        _count = userList.Count;
        Console.WriteLine($"You listed {_count} items!");
        
        base.DisplayingEndingMessage();
        


    }
    public void GetRandomPrompt()
    {
        Random random = new Random();
        int i =random.Next(_prompts.Count);
        Console.WriteLine($"--- {_prompts[i]} ---");
    }
    public List<string> GetListFromUser()
    {
        List<string> inputs = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string entry = Console.ReadLine();
            if (!string.IsNullOrEmpty(entry))
            {
                inputs.Add(entry);
            }
            
        }
        return inputs;
    }
}
