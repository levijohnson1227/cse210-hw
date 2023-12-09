using System.Runtime.CompilerServices;
using System.Transactions;

class Video
{
    private string _title { get; set; }
    private string _author { get; set; }
    private int _length { get; set; }

    public List<Comment> CommentList = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        CommentList = new List<Comment>();

    }

    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"{_length} seconds");

        Console.WriteLine("Comments:");
        foreach (var comment in CommentList)
        {
            comment.DisplayComment();
        }

        Console.WriteLine();
    }
    public int CommentNumber()
    {
        return CommentList.Count;
    }


}