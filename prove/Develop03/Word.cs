using System;

public class Word
{
    private string _word;
    private bool _isHidden;
    
    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    public void Display()
    {
        if(_isHidden == false)
        {
            Console.Write($"{_word} ");
        } else
        {
            Console.Write(new string('_', _word.Length) + " ");
        }
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
}