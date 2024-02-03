using System;
using System.Diagnostics.Tracing;
using System.Threading;

public class ListingActivity : Activity
{

    private List<string> _prompts => new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt(_prompts);
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        List<string> responses = GetListFromUser();
        Console.WriteLine($"You listed {responses.Count} items!");

        DisplayEndingMessage();
    }
    public void GetRandomPrompt(List<string> list)
    {
        Random random = new Random();

        int randomIndex = random.Next(0, list.Count);
        string randomPrompt = list[randomIndex];
        Console.WriteLine($"--- {randomPrompt} ---");
    }
    public List<string> GetListFromUser()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        List<string> userResponses = new List<string>();
        Console.WriteLine();
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            userResponses.Add(response);
        }
        return userResponses;
    }
}
