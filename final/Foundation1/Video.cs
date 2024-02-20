using System;
using System.Collections.Generic;
abstract class Video
{
    public string Title { get; }
    public string Author { get; }
    public int LengthSeconds { get; }
    protected List<Comment> Comments { get; }

    public Video(string title, string author, int lengthSeconds)
    {
        Title = title;
        Author = author;
        LengthSeconds = lengthSeconds;
        Comments = new List<Comment>();
    }

    // Abstract method to add a comment
    public abstract void AddComment(string commenterName, string commentText);

    // Abstract method to get the number of comments
    public abstract int GetNumComments();

    // Abstract method to display video information
    public abstract void DisplayInfo();
}