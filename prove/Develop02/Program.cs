using System;

class Program
{
    static void Main(string[] args)
    {
        
        Journal myJournal = new Journal();
        Menu menu = new Menu();
        PromptGen gen = new PromptGen();

        Prompt prompt1 = new Prompt();
        prompt1._prompt = "What was the best part of my day today?";

        Prompt prompt2 = new Prompt();
        prompt2._prompt = "What am I feeling right now, and why?";

        Prompt prompt3 = new Prompt();
        prompt3._prompt = "What is one thing I learned today?";

        Prompt prompt4 = new Prompt();
        prompt4._prompt = "What is something that stressed me out today?";

        Prompt prompt5 = new Prompt();
        prompt5._prompt = "What is one thing I am grateful for right now?";

        gen._prompts.Add(prompt1);
        gen._prompts.Add(prompt2);
        gen._prompts.Add(prompt3);
        gen._prompts.Add(prompt4);
        gen._prompts.Add(prompt5);

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
        opt5._name = "Quit";

        // add menu options to menu
        menu._menuOptions.Add(opt1);
        menu._menuOptions.Add(opt2);
        menu._menuOptions.Add(opt3);
        menu._menuOptions.Add(opt4);
        menu._menuOptions.Add(opt5);

        
        string userSelection = "";

        do {
            Console.WriteLine();
            Console.WriteLine("===================================");
            Console.WriteLine();

            // show menu and get user selection
            menu.Display();
            userSelection = menu.GetUserInput();
            if(userSelection == "1")
            {
                string randomPrompt = gen.GenerateRandomPrompt();
                myJournal.MakeEntry(randomPrompt);
            } 
            else if(userSelection == "2")
            {
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

        } while (userSelection != "5");
        
        // goodbye!
        Console.WriteLine("Goodbye!");
    }
}