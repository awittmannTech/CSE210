using System;
using System.IO;

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

            string filename = null;

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
                        case "3":
                            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                            int completion_cnt_goal = int.Parse(Console.ReadLine());

                            Console.Write("What is the bonus for accomplishing it that many times? ");
                            int completion_bonus = int.Parse(Console.ReadLine());

                            goal = new MultiGoal(goal_points, goal_name, goal_description, completion_bonus, completion_cnt_goal);
                            break;
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
                    
                    Console.Write("What do you want to name your goal file? ");
                    filename = Console.ReadLine() + ".csv";

                    using (StreamWriter outputFile = new StreamWriter(filename))
                    {
                        outputFile.WriteLine(points);
                        foreach(Goal g in goals)
                        {
                            outputFile.WriteLine(g.GetSerializedGoal()); 
                        }
                    }

                    break;
                case "4":
                    Console.Write("What is the name of your goals save file? ");
                    filename = Console.ReadLine() + ".csv";

                    string[] lines = System.IO.File.ReadAllLines(filename);

                    foreach (string line in lines)
                    {
                        if (lines[0] == line)
                        {
                            points = int.Parse(line);
                            continue;
                        }
                        string[] parts = line.Split(",");

                        string goal_type = parts[0];
                        Goal loadedGoal = null;

                        switch (goal_type)
                        {
                            case "OneTime":
                                loadedGoal = new OneTime(
                                    int.Parse(parts[3]),
                                    parts[1],
                                    parts[2],
                                    bool.Parse(parts[4])
                                );
                                break;
                            case "Eternal":
                                loadedGoal = new Eternal(
                                    int.Parse(parts[3]),
                                    parts[1],
                                    parts[2]
                                );
                                break;
                            case "MultiGoal":
                                loadedGoal = new MultiGoal(
                                    int.Parse(parts[3]),
                                    parts[1],
                                    parts[2],
                                    int.Parse(parts[5]),
                                    int.Parse(parts[4])
                                );
                                break;
                        }

                        goals.Add(loadedGoal);
                    }

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