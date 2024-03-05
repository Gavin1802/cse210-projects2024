using System;

class Listing : Activity
{
    public Listing() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }

    public override void Start(int duration)
    {
        base.Start(duration);
        ListItems(duration);
    }

    private void ListItems(int duration)
    {
        string[] prompts = {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        string randomPrompt = prompts[new Random().Next(prompts.Length)];

        Console.Clear();
        Console.WriteLine($"Consider the following prompt: ");
        Console.WriteLine("");
        Console.WriteLine($"--- {randomPrompt} ---");
        Console.WriteLine("");
        Console.WriteLine("You have " + duration + " seconds to list as many items as you can.");
        showSpinner(2); // Spin for 2 seconds
        Console.WriteLine("");
        Console.Write("You may begin in: ");
        Countdown(3);
        Console.WriteLine("");

        List<string> listedItems = new List<string>();
        Console.WriteLine("\nEnter your responses (press Enter after each item):");
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        int itemCount = 0;

        while (DateTime.Now < endTime)
        {
            string response = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(response))
                break;

            listedItems.Add(response);
            itemCount++;
        }

        Console.WriteLine($"\nYou listed {itemCount} items in response to the prompt");

        showSpinner(4);
        End();
    }
}
