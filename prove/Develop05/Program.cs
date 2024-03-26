using System;

class Program
{
    static internal int points = 0;
    public static List<Goal> Goals = new List<Goal>();

    static void Main(string[] args)
    {
        bool run = true;

        while (run)
        {
            int userChoice = DisplayMenu();
            if (userChoice == 1) //Create a new Goal
            {
                Goal.NewGoal();
            }
            else if (userChoice == 2) //List my goals 
            {
                Goal.DisplayGoals();
            }
            else if (userChoice == 3) //Save goals to a file
            {
                var text = Goal.Export();
                SaveToFile();
            }
            else if (userChoice == 4) //Load goals from a file
            {
                ReadFile();
            }
            else if (userChoice == 5) //Record an Event
            {
                RecordEvent();
            }
            else if (userChoice == 6) //Quit the program
            {
                run = false;
            }
            else
            {
                Console.WriteLine("Sorry, could you try another response?");
            }
        }
    }

    static int DisplayMenu()
    {
        Console.WriteLine($"You have {points} points.");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("    1) Create New Goal");
        Console.WriteLine("    2) List Goals");
        Console.WriteLine("    3) Save Goals");
        Console.WriteLine("    4) Load Goals");
        Console.WriteLine("    5) Record Event");
        Console.WriteLine("    6) Quit");
        Console.Write("What do you want to do?: ");

        var choice = int.Parse(Console.ReadLine());
        return choice;
    }

    static void RecordEvent()
    {
        Console.WriteLine("Select a goal to record an event for:");
        // Display a list of goals and let the user choose one
        int i = 1;
        foreach (var goal in Goals)
        {
            Console.WriteLine($"{i++}. {goal.name}");
        }
        int goalIndex = int.Parse(Console.ReadLine()) - 1;
        Goals[goalIndex].RecordEvent();
    }

    static void SaveToFile()
    {
        Console.WriteLine("Enter the name of the file to save the goals (without extension):");
        string fileName = Console.ReadLine();
        string filePath = $"{fileName}.txt";

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var goal in Goals)
            {
                string prefix = "";
                if (goal is SimpleGoal) prefix = "S";
                else if (goal is EternalGoal) prefix = "E";
                else if (goal is ChecklistGoal) prefix = "C";

                string goalLine = $"{prefix};{goal.name};{goal.description};{goal.pointvalue}";

                if (goal is ChecklistGoal checklistGoal)
                {
                    goalLine += $";{checklistGoal.TargetTimes}";
                }

                writer.WriteLine(goalLine);
            }
        }

        Console.WriteLine($"Goals saved to {filePath} successfully.");
    }

    static void ReadFile()
    {
        Console.WriteLine("Enter the name of the file to load goals from (including extension):");
        string fileName = Console.ReadLine();
        string filePath = fileName;

        string[] lines = File.ReadAllLines(filePath);
        Console.WriteLine($"Goals loaded from {filePath} successfully.");

        // Clear existing goals
        Goals.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split(';');

            // Check if the line has at least 4 parts
            if (parts.Length < 4)
            {
                Console.WriteLine($"Invalid data format for goal: {line}. Skipping...");
                continue;
            }

            string prefix = parts[0];
            string name = parts[1];
            string description = parts[2];
            int pointValue = int.Parse(parts[3]);

            Goal goal;

            // Determine the type of goal based on the prefix
            if (prefix == "S")
            {
                goal = new SimpleGoal(name, description, pointValue);
            }
            else if (prefix == "E")
            {
                goal = new EternalGoal(name, description, pointValue);
            }
            else if (prefix == "C")
            {
                int targetTimes;
                if (!int.TryParse(parts[4], out targetTimes))
                {
                    Console.WriteLine($"Invalid target times value for checklist goal: {line}. Skipping...");
                    continue;
                }
                goal = new ChecklistGoal(name, description, pointValue, targetTimes);
            }
            else
            {
                Console.WriteLine($"Unknown goal prefix: {prefix}. Skipping...");
                continue;
            }

            Goals.Add(goal);
        }
    }
}
