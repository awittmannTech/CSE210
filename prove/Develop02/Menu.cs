public class Menu
{
    public List<MenuOption> _menuOptions = new List<MenuOption>();
    
    public void Display()
    {
        Console.WriteLine($"");
        foreach (MenuOption opt in _menuOptions)
        {
            opt.Display();
        }
    }
    
    public string GetUserInput()
    {
        Console.Write("Enter your menu selection: ");
        return Console.ReadLine();
    }
}