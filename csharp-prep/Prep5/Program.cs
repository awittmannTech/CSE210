using System;

class Program
{
    
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }
    static int PromptUserBirthYear()
    {
        Console.Write("Please enter the year you were born: ");
        return int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int number)
    {
        return number * number;
    }
    static void DisplayResult(string fullName, int birthYear, int sqrtNumber)
    {
        // determine age
        int currentYear = DateTime.Now.Year;
        int age = currentYear - birthYear;

        Console.WriteLine($"{fullName}, the square of your number is {sqrtNumber}");
        Console.WriteLine($"{fullName}, you will turn {age} this year.");
    }



    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the program!");

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int userBirthYear = PromptUserBirthYear();

        int userNumberSqrt = SquareNumber(userNumber);

        DisplayResult(userName, userBirthYear, userNumberSqrt);
    }
}