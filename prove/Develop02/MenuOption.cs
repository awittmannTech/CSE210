public class MenuOption
{
    public int _optionNumber;
    public string _name;

    public void Display()
    {
        Console.WriteLine($"{_optionNumber}. {_name}");
    }
}