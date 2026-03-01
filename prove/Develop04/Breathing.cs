public class Breathing : Activity
{
    public Breathing(int duration, string name, string description) : base(duration, name, description)
    {
    }

    public int RunBreathing()
    {
        int cycleDuration = 5;

        DisplayIntroduction();
        int cycleCount = _duration / cycleDuration;

        for (int i = 0; i < cycleCount; i++)
        {
            if((i % 2) == 0) {
                Console.Write("Breathe in...");
            }else
            {
                Console.Write("Breathe out...");
            }
            DisplayCountdown(cycleDuration);
            Console.WriteLine();
        }
        
        DisplayConclusion();

        return _duration;

    }
}