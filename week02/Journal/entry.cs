public class Entry
{
    public string _date;
    public string _prompText;
    public string _entrytext;
    public void Display()
    {
        Console.WriteLine(_date);
        Console.Write(_prompText);
        Console.WriteLine(_entrytext);
    }
}