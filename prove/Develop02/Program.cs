using System;

// I'd like to say, I relied on Brother Lynn's program for much of this project.
// But I never copied and pasted, and I tried to follow his structure.
// I hope my inexperience isn't too apparent, but I'd like to say that I
// feel like I understand the principles a lot better because of it.

class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        //I like how Bro Lynn used a boolean to keep the while loop running
        bool run = true;

        while (run) 
        {
            Console.Clear();
            int userChoice = Display();
            if (userChoice == 1) //Write in a journal.
            {
                journal.WriteEntry();
            }
            else if (userChoice == 2) //Display a Journal 
            {
                Console.Clear();
                journal.DisplayJournal();
            }
            else if (userChoice == 3) //Save a journal to a file
            {
                var text = journal.Export();
                SaveToFile(text);
            }
            else if (userChoice == 4) //Load a journal from a file
            {
                var text = ReadFile();
            }
            else if (userChoice == 5) //Quit the program
            {
                run = false;
            }
            else
            {
                System.Console.WriteLine("Sorry, could you try another response?");
            }
        }
    }

    static int Display() {            
        System.Console.WriteLine("Welcome to the Journal Program!");
        System.Console.WriteLine("Please select one of the options below: ");
        System.Console.WriteLine("Write - 1");
        System.Console.WriteLine("Display - 2");
        System.Console.WriteLine("Save - 3");
        System.Console.WriteLine("Load - 4");
        System.Console.WriteLine("Quit - 5");
        System.Console.Write("What do you want to do?: ");

        var choice = int.Parse(Console.ReadLine());
        return choice;
    }

    static string[] ReadFile() {
        Console.Write("Please enter filename: ");
        var filename = Console.ReadLine();
        return System.IO.File.ReadAllLines(filename);
    }

    static void SaveToFile(string[] text) {
        Console.Write("Please enter filename: ");
        var filename = Console.ReadLine();
        System.IO.File.WriteAllLines(filename, text);
    }
}