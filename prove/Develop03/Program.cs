using System;

class Program
{
    static void Main(string[] args)
    {
        string scriptureText = "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.";
        Reference reference = new Reference("Proverbs", 3, 5, 6);


        string[] wordsArray = scriptureText.Split(' ');
        List<Word> wordsList = new List<Word>();
        foreach (string wordText in wordsArray)
        {
            wordsList.Add(new Word(wordText));
        }

        Scripture scripture = new Scripture(reference, wordsList);

        do
        {
            Console.Clear();
            scripture.GetDisplayText();

            Console.WriteLine("\nPress Enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(1);

        } while (!scripture.IsCompletelyHidden());


    }
}