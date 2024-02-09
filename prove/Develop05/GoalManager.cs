using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    protected internal int _score;

    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current score: {_score}");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i]._shortName}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStringRepresentation()}");
        }
    }

    public void CreateGoal(string name, string description, int points, int target = 0, int bonus = 0)
    {
        Goal goal;
        if (target == 0)
            goal = new SimpleGoal(name, description, points);
        else if (bonus == 0)
            goal = new EternalGoal(name, description, points);
        else
            goal = new ChecklistGoal(name, description, points, target, bonus);

        _goals.Add(goal);
    }

    public void RecordEvent(int goalNumber)
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            if (i + 1 == goalNumber)
            {
                if (_goals[i].IsComplete())
                { Console.WriteLine("This goal is already completed"); }
                else
                {
                    _goals[i].RecordEvent();
                    _score += _goals[i].CalculateScore();
                    Console.WriteLine($"Congratulations! You have earned {_goals[i].CalculateScore()} points!");
                    break;
                }
            }
        }

    }
    public void SaveGoals(string filename)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine($"{_score}");
                foreach (Goal goal in _goals)
                {
                    if (goal is ChecklistGoal checklistGoal)
                    {
                        writer.WriteLine($"{goal.GetType()}:{goal._shortName},{goal._description},{goal._points},{checklistGoal._bonus},{checklistGoal._target},{checklistGoal._amountCompleted}");
                    }
                    else if (goal is SimpleGoal simpleGoal)
                    {
                        writer.WriteLine($"{goal.GetType()}:{goal._shortName},{goal._description},{goal._points},{simpleGoal.IsComplete()}");
                    }
                    else
                        writer.WriteLine($"{goal.GetType()}:{goal._shortName},{goal._description},{goal._points}");
                }
            }
            Console.WriteLine("Goals saved to file successfully.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error saving goals to file: {e.Message}");
        }
    }
    public void LoadGoals(string filename)
    {
        try
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                bool isFirstLine = true;
                while ((line = reader.ReadLine()) != null)
                {
                    if (isFirstLine)
                    {
                        int score = int.Parse(line);
                        isFirstLine = false;
                        _score = score;
                        continue;
                    }

                    string[] parts = line.Split(',');
                    string[] goalInfo = parts[0].Split(':');
                    string goalType = goalInfo[0];
                    string[] goalDetails = parts[1].Split(',');

                    string name = goalInfo[1];
                    string description = goalDetails[0];
                    int points = int.Parse(parts[2]);

                    switch (goalType)
                    {
                        case "SimpleGoal":
                            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                            bool isComplete = bool.Parse(parts[3]);
                            if (isComplete == true)
                            {
                                simpleGoal.RecordEvent();
                            }
                            _goals.Add(simpleGoal);
                            break;
                        case "EternalGoal":
                            _goals.Add(new EternalGoal(name, description, points));
                            break;
                        case "ChecklistGoal":
                            int target = int.Parse(parts[3]);
                            int bonus = int.Parse(parts[4]);
                            int amountCompleted = int.Parse(parts[5]);
                            _goals.Add(new ChecklistGoal(name, description, points, bonus, target, amountCompleted));
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Arquivo não encontrado.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
        }
    }
}


