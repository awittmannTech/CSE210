using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _wordList = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] words = text.Split(" ");
        
        foreach(string w in words)
        {
            Word newWord = new Word(w);
            _wordList.Add(newWord);
        }
    }
    
    public void Display()
    {
        _reference.Display();
        foreach (Word w in _wordList)
        {
            w.Display();
        }
    }

    public void HideRandWords()
    {
        List<Word> visableWords = new List<Word>();
        foreach(Word word in _wordList)
        {
            if(!word.IsHidden())
            {
                visableWords.Add(word);
            }
        }

        Random rand = new Random();
        for (int i = 1; i < 4 && visableWords.Count > 0; i++)
        {
            int hideThisWord = rand.Next(visableWords.Count);
            visableWords[hideThisWord].Hide();
            visableWords.RemoveAt(hideThisWord);
        }
    }

    public bool IsFullyHidden()
    {
        bool fullyHidden = true;

        foreach(Word word in _wordList)
        {
            if(!word.IsHidden())
            {
                fullyHidden = false;
            }
        }

        return fullyHidden;
    }
}