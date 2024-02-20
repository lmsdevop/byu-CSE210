using System;
using System.Collections.Generic;
abstract class Video
{
    public string _title { get; }
    public string _author { get; }
    public int _lengthSeconds { get; }
    protected List<Comment> _comments { get; }

    public Video(string title, string author, int lengthSeconds)
    {
        _title = title;
        _author = author;
        _lengthSeconds = lengthSeconds;
        _comments = new List<Comment>();
    }

    // Abstract method to add a comment
    public abstract void AddComment(string commenterName, string commentText);

    // Abstract method to get the number of comments
    public abstract int GetNumComments();

    // Abstract method to display video information
    public abstract void DisplayInfo();
}