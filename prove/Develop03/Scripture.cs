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
            if(w._isHidden == false)
            {
                Console.Write($"{w._word} ");
            } else
            {
                Console.Write("____ ");
            }
        }
    }
}