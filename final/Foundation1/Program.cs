using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>
        {
            new YouTubeVideo("Video 1", "Author 1", 120),
            new YouTubeVideo("Video 2", "Author 2", 180),
            new YouTubeVideo("Video 3", "Author 3", 150)
        };

        // Adding comments to videos
        _videos[0].AddComment("User 1", "Great video!");
        _videos[0].AddComment("User 2", "Very informative");
        _videos[0].AddComment("User 3", "Nice work!");

        _videos[1].AddComment("User 4", "Loved it!");
        _videos[1].AddComment("User 5", "Amazing content!");

        _videos[2].AddComment("User 6", "Interesting topic!");
        _videos[2].AddComment("User 7", "Informative video!");

        // Displaying video information
        foreach (var video in _videos)
        {
            video.DisplayInfo();
            Console.WriteLine();
        }
    }
}