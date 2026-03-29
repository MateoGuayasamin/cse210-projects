using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        Comment comment1Video1 = new Comment("Mateoguayasamin","the product is good");
        Comment comment2Video1 = new Comment("Mateoguayasamin","the product is good");
        Comment comment3Video1 = new Comment("Mateoguayasamin","the product is good");
        Comment comment4Video1 = new Comment("Mateoguayasamin","the product is good");
        Video video1 = new Video("Video1","MateoGs", 28.21);
        
        video1._comments.Add(comment1Video1);
        video1._comments.Add(comment2Video1);
        video1._comments.Add(comment3Video1);
        video1._comments.Add(comment4Video1);

        video1.GetDisplay();

        Comment comment1Video2 = new Comment("Mateoguayasamin","the product is good");
        Comment comment2Video2 = new Comment("Mateoguayasamin","the product is good");
        Comment comment3Video2 = new Comment("Mateoguayasamin","the product is good");
        Comment comment4Video2 = new Comment("Mateoguayasamin","the product is good");
        Video video2 = new Video("Video1","MateoGs", 28.21);
        
        video2._comments.Add(comment1Video2);
        video2._comments.Add(comment2Video2);
        video2._comments.Add(comment3Video2);
        video2._comments.Add(comment4Video2);

        video2.GetDisplay();
    }
}