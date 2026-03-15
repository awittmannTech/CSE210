using System;

class Program
{
    static void Main(string[] args)
    {
        
        List<Goal> goals = new List<Goal>();
        int points = 0;
        string choice = "";

        List<string> menu_options = ["Create New Goal", "List Goals", "Save Goals", "Load Goals", "Record Event", "Quit"];
        List<string> goal_types = ["Simple Goal", "Eternal Goal", "Checklist Goal"];
        

        while(choice != "6") {

            Console.WriteLine("Menu Options: ");

            Console.WriteLine($"You have {points} points.");
            Console.WriteLine();

            int x = 1;
            foreach(string opt in menu_options)
            {
                Console.WriteLine($"  {x}. {opt}");
                x += 1;
            }

            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            switch
            (choice)
            {
                case "1":
                    
                    int y = 1;
                    foreach(string opt in goal_types)
                    {
                        Console.WriteLine($"  {y}. {opt}");
                        y += 1;
                    }
                    
                    Console.Write("Which type of goal would you like to create? ");
                    string goal_selection = Console.ReadLine();

                    Console.Write("What is the name of your goal? ");
                    string goal_name = Console.ReadLine();

                    Console.Write("What is a short description of it? ");
                    string goal_description = Console.ReadLine();

                    Console.Write("What is the amount of points associated with this goal? ");
                    int goal_points = int.Parse(Console.ReadLine());

                    Goal goal = null;

                    switch (goal_selection)
                    {
                        case "1":
                            goal = new OneTime(goal_points, goal_name, goal_description, false);
                            break;
                        case "2":
                            goal = new Eternal(goal_points, goal_name, goal_description);
                            break;
                        // case "3":
                        //     goal = new MultiGoal(goal_points, goal_name, goal_description);
                        //     break;
                    }

                    goals.Add(goal);
    
                    break;
                case "2":
                    
                    Console.WriteLine("The goals are: ");
                    int index = 1;
                    foreach(Goal goal_itm in goals)
                    {
                        goal_itm.DisplayGoal(index);
                        index += 1;
                    }

                    break;
                case "3":
                    Console.WriteLine("Saving goals...");
                    break;
                case "4":
                    Console.WriteLine("Loading goals...");
                    break;
                case "5":
                    Console.WriteLine("Recording event...");
                    break;
                case "6":
                    Console.WriteLine("Quitting...");
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }

        }

        Console.WriteLine("Goodbye!");

    }
}