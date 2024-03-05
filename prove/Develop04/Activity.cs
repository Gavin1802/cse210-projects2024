using System;  

class Activity
{
    protected string name;
    protected string description;

    public Activity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public virtual void Start(int duration)
    {
        Console.Clear();
        Console.WriteLine($"\nStarting {name} activity:");
        Console.WriteLine("");
        Console.WriteLine(description);
        Console.WriteLine("");
        showSpinner(5);  // Spin for 5 seconds before starting
    }

    public virtual void End()
    {
        Console.WriteLine($"\nGood job! You have completed the {name} activity.");
        showSpinner(4);  // Spin for 2 seconds before finishing
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000); // Pause for 1 second
            Console.Write("\b \b");
        }
    }

    protected void showSpinner(int time)
    {
        List<string> animationStrings = new List<String>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write($"{s}");
            Thread.Sleep(125);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }
}



