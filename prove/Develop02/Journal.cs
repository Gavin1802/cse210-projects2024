public class Journal
{
    public List<JournalEntry> entries = new List<JournalEntry>();

    public Journal(){}

    public Journal(string[] importLines){
        foreach(string line in importLines){
            entries.Add(new JournalEntry(line));
        }
    }

    public void WriteEntry() {
        List<string> prompts = new List<string>
        {       //Here is my prompt list:
            "Who is someone I talked to today? What did I talk about with them?",
            "What is something I learned from my reading in the Scriptures today?",
            "What is one mistake I made today? How can I improve tomorrow?",
            "What was the most spiritual moment I had today?",
            "What was the general mood of the day? Why?",
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?"                       
        }; 

        //now to choose one at random
        Random random = new Random();
        var prompt = prompts[random.Next(prompts.Count)]; 

        System.Console.WriteLine("Do you want to write your own prompt? (yes or no)");
        var userChoice = System.Console.ReadLine();

        if (userChoice == "yes")
        {
            System.Console.Write("Please write your prompt: ");
            prompt = System.Console.ReadLine();
        }

        System.Console.WriteLine($"Prompt: {prompt}");
        System.Console.WriteLine("Please enter your response: ");
        var userResponse = Console.ReadLine();
        
        System.Console.Write("Please enter the date (mm/dd/yy): ");
        string givenDate = Console.ReadLine();

        JournalEntry entry = new JournalEntry(userResponse, prompt, givenDate);

        entries.Add(entry);
    }

    // Display the entries from the journal
    public void DisplayJournal()
    {
        Console.Clear();
        Console.WriteLine("Journal Entries:");
        Console.WriteLine("-----------");
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }

        Console.WriteLine("");
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }

    public string[] Export()
    {
       var exportText = new List<string>();
       foreach (var entry in entries) 
       {
            exportText.Add(entry.Export());
       }
       return exportText.ToArray();
    }

}
