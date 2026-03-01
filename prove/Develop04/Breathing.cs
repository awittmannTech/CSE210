public class Breathing : Activity
{
    public Breathing(int duration, string name, string description) : base(duration, name, description)
    {
    }

    public void RunBreathing()
    {
        int cycleDuration = 5;

        displayIntroduction();
        int cycleCount = _duration / cycleDuration;

        for (int i = 0; i < cycleCount; i++)
        {
            if((i % 2) == 0) {
                Console.Write("Breathe in...");
            }else
            {
                Console.Write("Breathe out...");
            }
            for (int x = 0; x < cycleDuration; x++)
            {
                Console.Write(cycleDuration - x);

                Thread.Sleep(1000);

                Console.Write("\b \b"); // Erase the + character
            }
            Console.WriteLine();
        }
        
        displayConclusion();

    }
}