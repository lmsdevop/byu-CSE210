using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your score?");
        string number = Console.ReadLine();
        int courseGrade = int.Parse(number);

        string letter;

        if (courseGrade >= 90)
        {
            letter = "A";
        }
        else if (courseGrade >= 80)
        {
            letter = "B";
        }
        else if (courseGrade >= 70)
        {
            letter = "C";
        }
        else if (courseGrade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int lastDigit = courseGrade % 10;
        string sign = "";

        if (letter != "F")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        if (letter == "A" && lastDigit >= 7)
        {
            letter = "A-";
            sign = "";
        }
        else if (letter == "F")
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (courseGrade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Don't worry, keep working hard for next time!");
        }
    }
}