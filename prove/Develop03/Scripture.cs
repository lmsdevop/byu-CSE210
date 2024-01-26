using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, List<Word> words)
    {
        _reference = reference;
        _words.AddRange(words);
    }
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        for (int i = 0; i < numberToHide; i++)
        {
            int index = random.Next(_words.Count);
            _words[index].Hide();
        }
    }
    public string GetDisplayText()
    {
        string displayText = $"{_reference.GetDisplayText()}: ";

        foreach (Word word in _words)
        {
            displayText += $"{word.GetDisplayText()} ";
        }

        Console.WriteLine(displayText.Trim());
        return displayText.Trim();
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden)
                return false;
        }
        return true;
    }
}