public class Breathing : Activity
{
    public Breathing(int duration, string name, string description) : base(duration, name, description)
    {
    }

    public void runBreathing()
    {
        int cycleDuration = 5;

        int cycleCount = _duration / cycleDuration;
        displayIntroduction();

        for (int i = 0; i < cycleCount; i++)
        {
            if((i % 2) == 0) {
                Console.Write("Breathe in...");
            }else
            {
                Console.Write("Breathe out...");
            }
            for (int x = 1; x == cycleDuration; x++)
            {
                Console.Write(x);

                Thread.Sleep(1000);

                Console.Write("\b \b"); // Erase the + character
            }
        }
        
        
    }
}