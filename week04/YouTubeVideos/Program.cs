using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        List<Comment> makeComment(string name, string text)
        {
            List<Comment> comments = new List<Comment>();
            for (int i = 0; i < 3; i++)
        {
            Comment comment = new Comment(name, text);
            comments.Add(comment);
            return comments;
        }
        }

        List<Comment> makeCommentList()
        {
            makeComment
        }
        

        List<Video> videos = new List<Video>();
        void makeVideo(string title, string author, double length, List<Comment> comments)
        {
            for (int i = 0; i < 4; i++)
        {
            Video video = new Video(title, author, length, comments);
            videos.Add(video);
        }
        }

        makeVideo("Summer Cabin", "Bob Ross", 10.3, makeComment("Leonard", "I like this")); 
    }
}