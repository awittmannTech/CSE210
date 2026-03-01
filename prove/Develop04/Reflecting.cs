public class Reflecting : Activity
{
    private string _prompt = "";
    private string _quetsion = "";

    public Reflecting(string prompt, string question, int duration, string name, string description) : base(duration, name, description)
    {
        _prompt = prompt;
        _quetsion = question;
    }

    public void RunReflecting()
    {
        
    }
}