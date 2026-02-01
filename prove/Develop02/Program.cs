using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        
        Menu menu = new Menu();

        // generate menu options
        MenuOption opt1 = new MenuOption();
        opt1._optionNumber = 1;
        opt1._name = "Write new entry";

        MenuOption opt2 = new MenuOption();
        opt2._optionNumber = 2;
        opt2._name = "Display journal entries";

        MenuOption opt3 = new MenuOption();
        opt3._optionNumber = 3;
        opt3._name = "Save journal to a file";

        MenuOption opt4 = new MenuOption();
        opt4._optionNumber = 4;
        opt4._name = "Load journal from file";

        MenuOption opt5 = new MenuOption(); 
        opt5._optionNumber = 5;
        opt5._name = "See menu options";

        // add menu options to menu
        menu._menuOptions.Add(opt1);
        menu._menuOptions.Add(opt2);
        menu._menuOptions.Add(opt3);
        menu._menuOptions.Add(opt4);
        menu._menuOptions.Add(opt5);

        menu.Display();
        string userSelection = menu.GetUserInput();

        if(userSelection == "1")
        {
            myJournal
        } 
        else if(userSelection == "2")
        {
            // display journal entries
            myJournal.DisplayEntries();
        }
        else if(userSelection == "3")
        {
            // save journal to a file
            myJournal.Save();
        }
        else if(userSelection == "4")
        {
            // load journal from a file
            myJournal = myJournal.Load();
        }
        else if(userSelection == "5")
        {
            menu.Display();
        }
    }
}