public class Word
{
    public string _word;
    public bool _isHidden;
    
    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }
    public string GetWord()
    {
        return _word;
    }

    public void HideWord()
    {
        _isHidden = true;
    }
}