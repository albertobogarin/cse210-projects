using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video v1 = new Video("Learn C# in 10 Minutes", "Code Academy", 600);
        v1.AddComment(new Comment("Alice", "Great tutorial!"));
        v1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        v1.AddComment(new Comment("Maria", "I finally understand classes!"));
        videos.Add(v1);

        // Video 2
        Video v2 = new Video("Top 10 Programming Tips", "DevMaster", 420);
        v2.AddComment(new Comment("Carlos", "Tip #3 was gold."));
        v2.AddComment(new Comment("Dani", "I'm using these in my project."));
        v2.AddComment(new Comment("Leo", "Awesome content!"));
        videos.Add(v2);

        // Video 3
        Video v3 = new Video("How to Build a Website", "WebPro", 900);
        v3.AddComment(new Comment("Ana", "Clear explanation."));
        v3.AddComment(new Comment("Ronny", "This helped me with my homework."));
        v3.AddComment(new Comment("Laura", "Subscribed!"));
        videos.Add(v3);

        // Display all videos
        foreach (Video video in videos)
        {
            video.Display();
            Console.WriteLine();
        }
    }
}