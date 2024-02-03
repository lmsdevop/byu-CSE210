using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

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


        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountDown(6);
            Console.WriteLine();
            Console.WriteLine();

        }

        DisplayEndingMessage();

    }
}