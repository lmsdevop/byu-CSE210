using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>
        {
            new YouTubeVideo("Video 1", "Author 1", 120),
            new YouTubeVideo("Video 2", "Author 2", 180),
            new YouTubeVideo("Video 3", "Author 3", 150)
        };

        // Adding comments to videos
        videos[0].AddComment("User 1", "Great video!");
        videos[0].AddComment("User 2", "Very informative");
        videos[0].AddComment("User 3", "Nice work!");

        videos[1].AddComment("User 4", "Loved it!");
        videos[1].AddComment("User 5", "Amazing content!");

        videos[2].AddComment("User 6", "Interesting topic!");
        videos[2].AddComment("User 7", "Informative video!");

        // Displaying video information
        foreach (var video in videos)
        {
            video.DisplayInfo();
            Console.WriteLine();
        }
    }
}