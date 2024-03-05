using System;

class Reflection : Activity
{
    public Reflection() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") { }

    public override void Start(int duration)
    {
        base.Start(duration);
        Reflect(duration);
    }

    private void Reflect(int duration)
    {
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        string[] prompts = {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        string randomPrompt = prompts[new Random().Next(prompts.Length)];
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine("");
        Console.WriteLine($"--- {randomPrompt} ---");
        Console.WriteLine("");
        showSpinner(6); // Spin for 6 seconds before starting reflection
        Console.Clear();

        string[] questions = {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        foreach (string question in questions)
        {
            if (DateTime.Now >= endTime)
                break;
            Console.WriteLine($"> {question}");
            showSpinner(4); // Spin for 4 seconds between questions
        }
        End();
    }
}
