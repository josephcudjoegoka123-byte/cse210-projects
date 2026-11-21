using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to Learn C# in 10 Minutes", "Code Academy", 600);
        video1.AddComment(new Comment("Sarah", "This was so helpful, thank you!"));
        video1.AddComment(new Comment("John", "I finally understand classes now."));
        video1.AddComment(new Comment("Mike", "Can you do one for Python next?"));
        videos.Add(video1);

        Video video2 = new Video("Top 10 Travel Destinations in 2026", "Travel With Me", 1250);
        video2.AddComment(new Comment("Emma", "Japan is definitely on my list!"));
        video2.AddComment(new Comment("David", "Great video, amazing editing."));
        video2.AddComment(new Comment("Lily", "I went to Italy last year, loved it."));
        video2.AddComment(new Comment("Chris", "Add Jamaica to the list!"));
        videos.Add(video2);

        Video video3 = new Video("Easy Chicken Pasta Recipe", "Cooking Daily", 480);
        video3.AddComment(new Comment("Anna", "Made this tonight, my family loved it."));
        video3.AddComment(new Comment("Tom", "So easy and delicious."));
        video3.AddComment(new Comment("Sophia", "What can I use instead of cream?"));
        videos.Add(video3);

        Video video4 = new Video("Why Abstraction Matters in Programming", "BYU Pathway", 900);
        video4.AddComment(new Comment("James", "This finally clicked for me."));
        video4.AddComment(new Comment("Maria", "Great explanation!"));
        video4.AddComment(new Comment("Alex", "Need more examples like this."));
        videos.Add(video4);

        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}