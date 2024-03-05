using System;

class Breathing : Activity
{
    public Breathing() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    public override void Start(int duration)
    {
        base.Start(duration);
        Breathe(duration);
    }

    private void Breathe(int duration)
    {
        int cycleTime = 6000; // 6 seconds per breath cycle
        int breaths = (duration * 1000) / cycleTime;
        for (int i = 0; i < breaths; i++)
        {
            Console.Write("Breathe in...");
            Countdown(2);
            Console.WriteLine("");
            Console.Write("Now, breathe out...");
            Countdown(4);
            Console.WriteLine("");
        }
        End();
    }
    
}
