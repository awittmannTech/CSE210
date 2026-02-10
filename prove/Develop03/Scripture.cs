public class Scripture
{
    public string _reference;
    public List<Word> _wordList = new List<Word>();
    
    public void Display()
    {
        Console.WriteLine($"");
        foreach (Word w in _wordList)
        {
            Console.Write(w._word);
        }
    }
}