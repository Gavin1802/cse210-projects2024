class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int pointValue)
    {
        this.name = name;
        this.description = description;
        this.pointvalue = pointValue;
    }

    public override void RecordEvent()
    {
        Program.points += pointvalue;
        Console.WriteLine($"Event recorded! You gained {pointvalue} points.");
    }
}