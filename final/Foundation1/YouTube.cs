using System;
using System.Collections.Generic;
class YouTubeVideo : Video
{
    public YouTubeVideo(string title, string author, int lengthSeconds) : base(title, author, lengthSeconds) { }

    // Implementation of adding a comment
    public override void AddComment(string commenterName, string commentText)
    {
        _comments.Add(new Comment(commenterName, commentText));
    }

    // Implementation of getting the number of comments
    public override int GetNumComments()
    {
        return _comments.Count;
    }

    // Implementation of displaying video information
    public override void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthSeconds} seconds");
        Console.WriteLine($"Number of comments: {GetNumComments()}");
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment);
        }
    }
}