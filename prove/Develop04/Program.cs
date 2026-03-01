// to go beyond the basic requirements, I added a total activity time tally and I added a validation check to the listening activity to only count entries that were not blank to be more accurate.

using System;
class Program
{
    static void Main(string[] args)
    {
       List<string> reflectingPrompts = new List<string> {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        List<string> reflectingQuestions = new List<string> {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times?",
            "What could you learn from this experience that applies to other situations?"
        };
        
        List<string> listeningQuestions = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        string choice = "";
        int totalActivityDuration = 0;
        
        while (choice != "4")
        {
            Console.WriteLine($"Total Activity Time: {totalActivityDuration}");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listening activity");
            Console.WriteLine(" 4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Breathing activity1 = new Breathing(0, "Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                totalActivityDuration += activity1.RunBreathing();
            } else if(choice == "2")
            {
                Reflecting activity2 = new Reflecting(reflectingPrompts, reflectingQuestions, 0, "Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                totalActivityDuration += activity2.RunReflecting();
            } else if(choice == "3")
            {
                Listening activity3 = new Listening(listeningQuestions, 0, "Listening", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                totalActivityDuration += activity3.RunListening();
            }
        }
    }
}