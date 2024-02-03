// I CREATED A NEW ACTIVITY CALLED GRATITUDE JOURNAL THAT GIVES A PROMPT TO THE USER AN THEY NEED TO LIST THREE THINGS ANSWERING THE PROMPT, AT THE END THE PROGRAM WILL SHOW THEM WHAT THEY ANSWERED

using System;

class Program
{
    static void Main()
    {

        Console.CursorVisible = false;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflection activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Start gratitude journal activity");
            Console.WriteLine("5. Quit");

            Console.Write("Select a choice from the menu: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int choice))
            {
                if (choice == 5)
                {
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                }

                switch (choice)
                {
                    case 1:
                        BreathingActivity breathing = new BreathingActivity();
                        breathing.Run();
                        break;
                    case 2:
                        ReflectionActivity reflection = new ReflectionActivity();
                        reflection.Run();
                        break;
                    case 3:
                        ListingActivity listing = new ListingActivity();
                        listing.Run();
                        break;

                    case 4:
                        GratitudeActivity gratitude = new GratitudeActivity();
                        gratitude.Run();
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
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