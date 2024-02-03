using System;
using System.Threading;

public class ReflectionActivity : Activity
{
    private List<string> _prompts => new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions => new List<string> {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        DisplayPrompt();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue");
        ConsoleKeyInfo key = Console.ReadKey();
        while (key.Key != ConsoleKey.Enter)
        {
            Console.WriteLine("\b \b");
            Console.WriteLine("Please press only Enter");
            key = Console.ReadKey();
        }
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following question as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            DisplayQuestions();
        }

        DisplayEndingMessage();
    }
    public string GetRandomPrompt(List<string> list)
    {
        Random random = new Random();

        int randomIndex = random.Next(0, list.Count);
        string randomPrompt = list[randomIndex];
        return randomPrompt;
    }
    public string GetRandomQuestion(List<string> list)
    {
        Random random = new Random();

        int randomIndex = random.Next(0, list.Count);
        string randomQuestion = list[randomIndex];
        return randomQuestion;
    }
    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt(_prompts);
        Console.WriteLine($"--- {prompt} ---");
    }
    public void DisplayQuestions()
    {
        string question = GetRandomPrompt(_questions);
        Console.Write($"> {question} ");
        ShowSpinner(15);
        Console.WriteLine();
    }
}
