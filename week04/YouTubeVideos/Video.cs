using System.ComponentModel.DataAnnotations;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private double _length;
    private List<Comment> _comments = new List<Comment>();

    public int ListComments()
    {
        return _comments.Count();
    }

    public Video(string title, string author, double length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Video Length: {_length}");
        Console.WriteLine($"Comments: {ListComments()}");

    }
}