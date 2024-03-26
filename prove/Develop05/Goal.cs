using System;
using System.Collections.Generic;

public abstract class Goal
{
    protected internal string name;
    protected internal string description;
    protected internal int pointvalue;

    public static void NewGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("    1) Simple Goal");
        Console.WriteLine("    2) Eternal Goal");
        Console.WriteLine("    3) Checklist Goal");
        Console.WriteLine("Which type of goal would you like to create?  ");
        var type = int.Parse(Console.ReadLine());
        if (type == 1)
        {
            Console.WriteLine("What is the name of the goal? ");
            string name = Console.ReadLine();

            Console.WriteLine("What is a short description? ");
            string description = Console.ReadLine();

            Console.WriteLine("How many points are associated with this goal? ");
            int pointvalue = int.Parse(Console.ReadLine());

            Program.Goals.Add(new SimpleGoal(name, description, pointvalue));
        }
        else if (type == 2)
        {
            Console.WriteLine("What is the name of the goal? ");
            string name = Console.ReadLine();

            Console.WriteLine("What is a short description? ");
            string description = Console.ReadLine();

            Console.WriteLine("How many points are associated with this goal? ");
            int pointvalue = int.Parse(Console.ReadLine());

            Program.Goals.Add(new EternalGoal(name, description, pointvalue));
        }
        else if (type == 3)
        {
            Console.WriteLine("What is the name of the goal? ");
            string name = Console.ReadLine();

            Console.WriteLine("What is a short description? ");
            string description = Console.ReadLine();

            Console.WriteLine("How many points are associated with this goal? ");
            int pointvalue = int.Parse(Console.ReadLine());

            Console.WriteLine("How many times does this goal need to be completed? ");
            int targetTimes = int.Parse(Console.ReadLine());

            Program.Goals.Add(new ChecklistGoal(name, description, pointvalue, targetTimes));
        }
    }

    // Display the entries from the journal
    public static void DisplayGoals()
    {
        Console.WriteLine("The Goals are:");
        foreach (var goal in Program.Goals)
        {
            Console.WriteLine(goal);
        }

        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }

    public virtual void RecordEvent()
    {
        // To be overridden by derived classes
    }

    public static string Export()
    {
        string exportData = "";
        foreach (var goal in Program.Goals)
        {
            string prefix = "";
            if (goal is SimpleGoal)
            {
                prefix = "S";
            }
            else if (goal is EternalGoal)
            {
                prefix = "E";
            }
            else if (goal is ChecklistGoal)
            {
                prefix = "C";
                // Append target times for ChecklistGoal
                exportData += $"{prefix};{goal.name};{goal.description};{goal.pointvalue};{(goal as ChecklistGoal).TargetTimes}\n";
                continue;
            }
            // Append data for SimpleGoal and EternalGoal
            exportData += $"{prefix};{goal.name};{goal.description};{goal.pointvalue}\n";
        }
        return exportData;
    }
}