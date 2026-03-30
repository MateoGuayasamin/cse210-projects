using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        Comment comment1Video1 = new Comment("Mateoguayasamin","the product is good");
        Comment comment2Video1 = new Comment("Julio Torres","the video is ok");
        Comment comment3Video1 = new Comment("Maria Smith","I like the video");
        Comment comment4Video1 = new Comment("Nephi ","I dont like the videp");
        Video video1 = new Video("Video1","MateoGs", 28.21);
        
        video1._comments.Add(comment1Video1);
        video1._comments.Add(comment2Video1);
        video1._comments.Add(comment3Video1);
        video1._comments.Add(comment4Video1);

        video1.GetDisplay();

        Comment comment1Video2 = new Comment("Jose Smith","the product is good");
        Comment comment2Video2 = new Comment("Dale Rendli]und","I already got the product");
        Comment comment3Video2 = new Comment("Tomas Monson","I wanna buy the product");
        Comment comment4Video2 = new Comment("Sidney Parker","the product is good");
        Video video2 = new Video("Video2","LuisDiaz", 15.27);
        
        video2._comments.Add(comment1Video2);
        video2._comments.Add(comment2Video2);
        video2._comments.Add(comment3Video2);
        video2._comments.Add(comment4Video2);

        video2.GetDisplay();

        Comment comment1Video3 = new Comment("Peter Parker","the product is good");
        Comment comment2Video3 = new Comment("Steve Rogers","I dont watch the video");
        Comment comment3Video3 = new Comment("Tony Stark","I really like the product");
        Comment comment4Video3 = new Comment("Bruce Banner","the product is ok");
        Video video3 = new Video("Video3","JuanPerez", 23.11);
        
        video3._comments.Add(comment1Video3);
        video3._comments.Add(comment2Video3);
        video3._comments.Add(comment3Video3);
        video3._comments.Add(comment4Video3);

        video3.GetDisplay();
    }
}