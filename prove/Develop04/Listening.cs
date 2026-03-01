public class Listening : Activity
{
    private List<string> _prompts = new List<string>();

    public Listening(List<string> prompts, int duration, string name, string description) : base(duration, name, description)
    {
        _prompts = prompts;
    }

    public void RunListening()
    {
        DisplayIntroduction();

        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];

        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("You may begin in: ");
        DisplayCountdown(5);

        int count = 0;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            if (response != "")
            {
                count++;
            }
        }

        Console.WriteLine($"You listed {count} items!");

        DisplayConclusion();

    }
}