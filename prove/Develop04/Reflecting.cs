public class Reflecting : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public Reflecting(List<string> prompts, List<string> questions, int duration, string name, string description) : base(duration, name, description)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public void RunReflecting()
    {
        DisplayIntroduction();

        int cycleDuration = _duration / 5;

        Console.WriteLine("Consider the following prompt: ");

        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];

        Console.WriteLine($"--- {prompt} ---");

        Console.WriteLine("When you have something in mind, please enter to continue. ");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.WriteLine("You may begin in: ");

        DisplayCountdown(5);

        Console.Clear();

        foreach(string question in _questions)
        {
            Console.WriteLine($"> {question}");
            DisplayLoadingSpinner(cycleDuration);
        }        

    }
}