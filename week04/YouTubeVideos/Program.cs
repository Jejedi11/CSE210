using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Comment> makeComment(string name1, string text1, string name2, string text2, string name3, string text3, string name4, string text4)
        {
            List<Comment> comments = new List<Comment>();
            Comment comment1 = new Comment(name1, text1);
            comments.Add(comment1);
            Comment comment2 = new Comment(name2, text2);
            comments.Add(comment2);
            Comment comment3 = new Comment(name3, text3);
            comments.Add(comment3);
            Comment comment4 = new Comment(name4, text4);
            comments.Add(comment4);
            return comments;
        }

        List<Video> videos = new List<Video>();
        void makeVideo(string title, string author, double length, List<Comment> comments)
        {
            Video video = new Video(title, author, length, comments);
            videos.Add(video);
        }

        makeVideo("Summer Cabin", "Bob Ross", 10.3, makeComment("Leonard", "I like this", "Stephen", "Wow, how does that work?", "Miriam", "I want to try this!", "Charles", "Nice Work!"));
        makeVideo("Boogie", "Disco Fred", 3.22, makeComment("Leonard", "I like this", "Stephen", "Wow, how does that work?", "Miriam", "I want to try this!", "Charles", "Nice Work!"));
        makeVideo("Piano Solo", "Han Piano", 4.10, makeComment("Leonard", "I like this", "Stephen", "Wow, how does that work?", "Miriam", "I want to try this!", "Charles", "Nice Work!"));
        makeVideo("Making a Living", "Charlie Chaplin", 8.30, makeComment("Leonard", "I like this", "Stephen", "Wow, how does that work?", "Miriam", "I want to try this!", "Charles", "Nice Work!"));
        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}