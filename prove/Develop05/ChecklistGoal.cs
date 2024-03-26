class ChecklistGoal : Goal
{
    private int completedTimes;
    public int TargetTimes { get; private set; }

    public ChecklistGoal(string name, string description, int pointValue, int targetTimes)
    {
        this.name = name;
        this.description = description;
        this.pointvalue = pointValue;
        this.TargetTimes = targetTimes;
    }

    public override void RecordEvent()
    {
        completedTimes++;
        Console.WriteLine($"{name} completed {completedTimes}/{TargetTimes} times.");
        Program.points += pointvalue;
        if (completedTimes >= TargetTimes)
        {
            Console.WriteLine($"Congratulations! You have completed {name} {TargetTimes} times and received a bonus of {pointvalue * 10} points!");
            Program.points += pointvalue * 10; // Bonus
        }
    }
}