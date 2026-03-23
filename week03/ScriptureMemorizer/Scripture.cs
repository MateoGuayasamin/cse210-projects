
using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture (Reference reference, string text)
    {
        _reference = reference;
        string[] allWords = text.Split(' ');
        foreach (string wordText in allWords)
        {
            _words.Add(new Word(wordText));
        }

    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;
        int visibleWords = 0;
        foreach (Word word in _words)
        {
            if (!word.IsHidden()) visibleWords++;
        }
        int actualLimit = numberToHide;
        if (numberToHide > visibleWords) actualLimit = visibleWords;
        while (hiddenCount < actualLimit)
        {
            int index = random.Next(_words.Count);
            
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    } 

    public string GetDisplay()
    {
        string displayText = _reference.GetDisplayText() + " ";
        
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }

        return displayText.Trim();
        
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}