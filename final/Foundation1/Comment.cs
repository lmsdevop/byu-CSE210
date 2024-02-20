using System;
using System.Collections.Generic;

class Comment
{
    public string _commenterName { get; }
    public string _commentText { get; }

    public Comment(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
    }

    public override string ToString()
    {
        return $"{_commenterName}: {_commentText}";
    }
}