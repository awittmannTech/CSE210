public class Listening : Activity
{
    private string _prompt = "";

    public Listening(string prompt, int duration, string name, string description) : base(duration, name, description)
    {
        _prompt = prompt;
    }

    public void RunListening()
    {
        
    }
}