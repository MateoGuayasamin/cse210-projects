using System.Dynamic;

public class Video
{
    public string _title;
    public string _author;
    public double _length;
    public List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, double lenght)

    {
        _title = title;
        _author = author;
        _length = lenght;
                 
    }

    public void GetDisplay()
    {
        Console.WriteLine($"{_title},{_author},{_length},"); 
        foreach(Comment comment in _comments)
        {
            comment.GetDisplatComment();
        }
        
    }

}