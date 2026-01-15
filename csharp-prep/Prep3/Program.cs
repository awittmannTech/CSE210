using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string response = "yes";
        int highScore = 9999999;

        while (response == "yes")
        {
            string guess = "0";
            int guessCnt = 0;

            Random randomNumGenerator = new Random();
            int magicNumber = randomNumGenerator.Next(1, 11);

            while ( int.Parse(guess) != magicNumber )
            {
                Console.Write("What is your guess? ");
                guess = Console.ReadLine();

                if(int.Parse(guess) != magicNumber)
                {
                    Console.Write("Nope, guess again... ");
                }

                guessCnt += 1;
            }

            Console.WriteLine($"You guess it! It was {magicNumber}!");
            Console.WriteLine($"It took you {guessCnt} tries.");

            if(guessCnt < highScore)
            {
                Console.WriteLine($"You set the new high score!");
                highScore = guessCnt;
            } else
            {
                Console.WriteLine($"High Score: {highScore}");
            }

            Console.WriteLine("Respond 'yes' to play again: ");
            response = Console.ReadLine();

        }

        Console.WriteLine("Goodbye!");
    }
}