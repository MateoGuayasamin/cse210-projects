public class BreathingActivity:Activity
{
    public BreathingActivity(string name, string description): base(name,description)
    {
        
    }
    public void Run()
    {
        base.DisplayingStartingMessage();
        base.ShowSpinner(10);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while(DateTime.Now < endTime)
        {
            Console.Write("Breathe in....");
            base.ShowCountDown(4);
            Console.WriteLine("");
            Console.Write("Breathe out....");
            base.ShowCountDown(6);
            Console.WriteLine("");
            Console.WriteLine("");

        }

        base.DisplayingEndingMessage();

    }
}