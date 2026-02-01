public class Prompt
{
    string _prompt;
    
    public void Display()
    {
        Console.WriteLine(_prompt);
    }

    public string GetPrompt()
    {
        return _prompt;
    }
}