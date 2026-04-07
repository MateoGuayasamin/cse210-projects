using System.ComponentModel;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description )
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    public void DisplayingStartingMessage()
    {
        
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine(_description);
        Console.WriteLine("How long, in seconds, would you like for your session?");
        string duration = Console.ReadLine();
        _duration = int.Parse(duration);

        Console.WriteLine("Get ready...");
        
    }
    public void DisplayingEndingMessage()
    {
        Console.WriteLine("Well Done !!");
        ShowCountDown(5);
        Console.Write($"You have completed another {_duration} seconds of the {_name}");
        ShowCountDown(5);
    }
    public void ShowSpinner(int seconds)
    {
        List<string> animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("|");
        animationString.Add("\\");
        animationString.Add("-");
        animationString.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;

        while(DateTime.Now < endTime)
        {
            string s =animationString[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;
            if (i >= animationString.Count )
            {
                i=0;
            }


        }
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");

        }
    }
}