using System;

class Program

{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        // Sample activities, format: Date, Minutes, Distance/Speed/Laps
        activities.Add(new Running("07 May 2024", 30, 3.0));
        activities.Add(new Running("06 May 2024", 30, 4.8));
        activities.Add(new Cycling("05 May 2024", 45, 15.0));
        activities.Add(new Swimming("04 May 2024", 60, 20));

        // Displaying summary for each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
