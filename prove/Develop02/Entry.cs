public class Entry
{
    public string _date;
    public string _prompt;
    public string _userInput;
    public string _dayRating;

    public void Display()
    {
        Console.WriteLine($"{_date}");
        Console.WriteLine($"{_prompt}");
        Console.WriteLine($"{_userInput}");
        Console.WriteLine($"{_dayRating} / 10");
    }
}