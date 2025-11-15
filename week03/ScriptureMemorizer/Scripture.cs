using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    private Random _random = new Random();

    
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

       
        string[] parts = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }

    
    public string GetDisplayText()
    {
        
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        sb.AppendLine(_reference.GetDisplayText());
        sb.AppendLine();

        for (int i = 0; i < _words.Count; i++)
        {
            sb.Append(_words[i].GetDisplayText());
            if (i < _words.Count - 1) sb.Append(" ");
        }

        return sb.ToString();
    }


    public void HideRandomWords(int count)
    {
        List<int> availableIndexes = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                availableIndexes.Add(i);
            }
        }

        if (availableIndexes.Count == 0) return; 

        
        int toHide = Math.Min(count, availableIndexes.Count);

        for (int k = 0; k < toHide; k++)
        {
            
            int pickIndex = _random.Next(availableIndexes.Count);
            int wordIndex = availableIndexes[pickIndex];

            // Ocultamos esa palabra
            _words[wordIndex].Hide();

            
            availableIndexes.RemoveAt(pickIndex);
        }
    }

    
    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden()) return false;
        }
        return true;
    }
}

