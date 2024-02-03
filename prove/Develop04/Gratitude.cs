using System;
using System.Threading;
using System.Collections.Generic;
using System.Net;

public class GratitudeActivity : Activity
{
    private List<string> gratitudePrompts;

    public GratitudeActivity() : base("Gratitude Journal", "This activity will help you cultivate gratitude by reflecting on positive aspects of your life and list them.")
    {
        gratitudePrompts = new List<string>
        {
            "List three things you are grateful for today.",
            "Reflect on a person who has had a positive impact on your life recently.",
            "Consider a challenge you faced and find something positive or a lesson learned from it.",
            "Think about a simple pleasure that brought you joy today.",
            "Express gratitude for your health and well-being.",
            "Consider a skill or talent you possess and appreciate it.",
            "Reflect on a past success and the positive aspects it brought to your life.",
            "Express gratitude for a nature-related experience you enjoyed recently.",
            "Think about a friend or family member you are thankful to have in your life.",
            "Consider a moment when someone showed kindness to you and express gratitude for it."
        };
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        List<string> response = new List<string>();

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            GetRandomPrompt(gratitudePrompts);
            response.AddRange(GetListFromUser());
            ShowSpinner(2);
        }

        Console.WriteLine();
        Console.WriteLine("Here is your list:");
        Console.WriteLine();
        foreach (string answer in response)
        {
            Console.WriteLine(answer);
        }

        DisplayEndingMessage();
    }

    private void GetRandomPrompt(List<string> prompts)
    {
        Random random = new Random();
        int randomIndex = random.Next(0, prompts.Count);
        string randomPrompt = prompts[randomIndex];
        Console.WriteLine($"--- {randomPrompt} ---");
    }

    public List<string> GetListFromUser()
    {
        List<string> userResponses = new List<string>();
        Console.WriteLine();
        int i = 0;
        while (i < 3)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            userResponses.Add(response);

            i++;
        }
        return userResponses;
    }
}