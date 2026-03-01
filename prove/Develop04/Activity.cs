using System.Security.Cryptography;

public class Activity
{
    protected int _duration = 0;
    protected string _description = "";
    protected string _name = "";

    public Activity(int duration, string name, string description)
    {
        _duration = duration;
        _description = description;
        _name = name;
    }

    protected void loadingSpinner(int duration)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("+");

            Thread.Sleep(500);

            Console.Write("\b \b"); // Erase the + character
            Console.Write("-"); // Replace it with the - character

            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }

    protected void displayIntroduction()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");

        Console.WriteLine($"{_description}");

        Console.Write("How long, in seconds, would you like for your session?");

        string duration = Console.ReadLine();
        _duration = int.Parse(duration);

        Console.WriteLine("Get ready...");
        loadingSpinner(6);
    }

    protected void displayConclusion()
    {
        Console.WriteLine("Well done!!\n\n");
        loadingSpinner(6);

        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        loadingSpinner(6);
    }
    
}