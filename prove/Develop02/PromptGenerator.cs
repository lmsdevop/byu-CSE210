using System;
using System.ComponentModel;

public class PromptGenerator
{
    public List<string> _prompts => new List<string>
        {
            "Hello, Lucas!",
            "How are you today?",
            "Welcome to the program."
        };

    public string GetRandomPrompt(List<string> list)
    {
        Random random = new Random();

        int randomIndex = random.Next(0, list.Count);
        string randomPrompt = list[randomIndex];
        return randomPrompt;
    }
}