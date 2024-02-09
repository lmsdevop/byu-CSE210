using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        Console.Clear();

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine($"You have {goalManager._score} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");

            Console.Write("Select a choice from the menu: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int choice))
            {
                if (choice == 6)
                {
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("The types of Goals are:");
                        Console.WriteLine("  1. Simple Goal");
                        Console.WriteLine("  2. Eternal Goal");
                        Console.WriteLine("  3. Checklist Goas");
                        Console.Write("Which type of goal would you like to create? ");
                        string _goal = Console.ReadLine();
                        Console.Write("What is the name of your goal? ");
                        string _shortName = Console.ReadLine();
                        Console.Write("What is a short description of it? ");
                        string _description = Console.ReadLine();
                        Console.Write("What is the amount of points associated with this goal? ");
                        int _points = int.Parse(Console.ReadLine());
                        if (int.TryParse(_goal, out int goalInt))

                            switch (goalInt)
                            {
                                case 1:

                                    goalManager.CreateGoal(_shortName, _description, _points);
                                    break;
                                case 2:
                                    goalManager.CreateGoal(_shortName, _description, _points, target: 1);
                                    break;
                                case 3:
                                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                                    int _target = int.Parse(Console.ReadLine());
                                    Console.Write("What is the bonus for accomplishing it that many times? ");
                                    int _bonus = int.Parse(Console.ReadLine());
                                    goalManager.CreateGoal(_shortName, _description, _points, _target, _bonus);

                                    break;
                                default:
                                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 3");
                                    break;
                            }
                        break;
                    case 2:
                        goalManager.ListGoalDetails();
                        break;
                    case 3:
                        Console.Write("What is the filename for the goal file? ");
                        string saveFileName = Console.ReadLine();
                        goalManager.SaveGoals($"{saveFileName}.txt");
                        break;
                    case 4:
                        Console.Write("What is the filename for the goal file? ");
                        string loadFileName = Console.ReadLine();
                        goalManager.LoadGoals($"{loadFileName}.txt");
                        break;
                    case 5:
                        goalManager.ListGoalNames();
                        Console.Write("Which goal did you accomplish? ");
                        int selection = int.Parse(Console.ReadLine());
                        goalManager.RecordEvent(selection);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

        }
    }
}