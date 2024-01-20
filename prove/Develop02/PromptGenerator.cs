using System;
using System.ComponentModel;

public class PromptGenerator
{
    public List<string> _prompts => new List<string>
        {
            "What unexpected event or surprise made today memorable for me?",
            "Reflect on a moment of personal growth or self-discovery that occurred today.",
            "Consider the people who positively influenced my day. How did their presence impact me?",
            "Identify a challenge or obstacle I faced today and explore what I learned from overcoming it.",
            "Recall a small act of kindness I either gave or received today and its impact on my mood.",
            "In what ways did today differ from my expectations, and how did those differences shape my experience?",
            "What skill or talent did I utilize today, and how did it contribute to my overall sense of accomplishment?",
            "Reflect on a decision I made today and analyze its consequences—positive or negative.",
            "How did the weather or environment influence my mood and activities throughout the day?",
            "Consider a moment of laughter or joy from today and delve into what made it special."
        };

    public string GetRandomPrompt(List<string> list)
    {
        Random random = new Random();

        int randomIndex = random.Next(0, list.Count);
        string randomPrompt = list[randomIndex];
        return randomPrompt;
    }
}